using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DobleCinco_BarberanCastillo
{
    public partial class BackUp : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["doble_cinco"].ConnectionString;
        public BackUp()
        {
            InitializeComponent();
        }

        private void BackUp_Load(object sender, EventArgs e)
        {

        }
        private void BRealizar_Click(object sender, EventArgs e)
        {
            string folder = "C:\\DobleCinco_BackUp\\";

            try
            {
                // Obtener el nombre de la base de datos desde la cadena de conexión
                var csb = new SqlConnectionStringBuilder(connectionString);
                string dbName = csb.InitialCatalog;
                if (string.IsNullOrEmpty(dbName))
                {
                    MessageBox.Show("No se pudo determinar el nombre de la base de datos desde la cadena de conexión.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Nombre de archivo con timestamp
                string fileName = $"{dbName}_{DateTime.Now:yyyyMMdd_HHmmss}.bak";
                string backupPath = Path.Combine(folder, fileName);

                // Escapar posibles comillas simples en la ruta
                string escapedPath = backupPath.Replace("'", "''");

                // Comando T-SQL de backup
                string sql = $"BACKUP DATABASE [{dbName}] TO DISK = N'{escapedPath}' WITH FORMAT, INIT, NAME = N'Full backup of {dbName}';";

                using (var conn = new SqlConnection(connectionString))
                using (var cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    // Si los backups tardan mucho, evita timeout
                    cmd.CommandTimeout = 0;
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show($"Backup realizado correctamente:\n{backupPath}", "Backup completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException sqlex)
            {
                // Mensaje común: permisos o ruta inaccesible desde el servidor
                MessageBox.Show("Error SQL al crear el backup: " + sqlex.Message + "\nComprueba permisos y que la ruta sea accesible por el servidor SQL.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar backup: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
