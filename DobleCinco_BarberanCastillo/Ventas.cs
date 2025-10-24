using DobleCinco_BarberanCastillo.Controles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DobleCinco_BarberanCastillo
{
    public partial class Ventas : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["doble_cinco"].ConnectionString;
        public Ventas()
        {
            InitializeComponent();
            ConfigurarDgvDetalleVenta();
        }

        private void Ventas_Load(object sender, EventArgs e)
        {

        }

        private void TBVendedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true; // Cancela el evento, evitando que el carácter se ingrese
            }
        }

        private void TBNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true; // Cancela el evento, evitando que el carácter se ingrese
            }
        }

        private void TBApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true; // Cancela el evento, evitando que el carácter se ingrese
            }
        }

        private void TBDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Cancela el evento, evitando que el carácter se ingrese
            }
        }

        private void TBStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Cancela el evento, evitando que el carácter se ingrese
            }
        }

        private void TBCosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true; // Cancela el evento, evitando que el carácter se ingrese
            }
        }

        private void TBVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true; // Cancela el evento, evitando que el carácter se ingrese
            }
        }

        private void BBuscarProducto_Click(object sender, EventArgs e)
        {
            BBuscarProducto.Enabled = false;
            string filtro_nombre = TBProducto.Text.Trim();
            string filtro_desc = TBDescripcion.Text.Trim();
            var formBusqueda = new BuscarProducto(filtro_nombre, filtro_desc);

            formBusqueda.ProductoSeleccionado += (id, descripcion, precio) =>
            {
                dgvDetalleVenta.Rows.Add(id, descripcion, 1, precio);
                TBDescripcion.Clear();
                TBDescripcion.Focus();
                BBuscarProducto.Enabled = true;
            };

            formBusqueda.FormClosed += (s, args) => BBuscarProducto.Enabled = true;

            formBusqueda.Show();
        }

        private void ConfigurarDgvDetalleVenta()
        {
            // Asegúrate de que el control no esté completamente en ReadOnly
            dgvDetalleVenta.ReadOnly = false;

            // Si usas nombres de columnas, ajústalos a los tuyos
            dgvDetalleVenta.Columns["id_producto"].ReadOnly = true;
            dgvDetalleVenta.Columns["producto_descripcion"].ReadOnly = true;
            dgvDetalleVenta.Columns["producto_cantidad"].ReadOnly = false;
            dgvDetalleVenta.Columns["producto_precio"].ReadOnly = true;

            // Opcional: facilitar la edición al entrar en la celda
            dgvDetalleVenta.EditMode = DataGridViewEditMode.EditOnEnter;
        }

        private void BVenta_Click(object sender, EventArgs e)
        {
            /*
            using (SqlConnection conn = new SqlConnection(connectionString))
            {

                try
                {
                    if (dgvDetalleVenta.Rows.Count == 0 || dgvDetalleVenta.Rows[0].IsNewRow)
                    {
                        MessageBox.Show("Debe agregar al menos un producto a la venta.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if(dgvDetalleVenta.Rows.Cast<DataGridViewRow>().Any(row => Convert.ToInt32(row.Cells["producto_cantidad"].Value) <= 0))
                    {
                        MessageBox.Show("La cantidad de los productos debe ser mayor a cero.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if(dgvDetalleVenta.Rows.Cast<DataGridViewRow>().Any(row => Convert.ToInt32(row.Cells["producto_cantidad"].Value) > ))
                    {
                        MessageBox.Show("La cantidad de un producto excede el stock disponible.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al realizar venta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            */
        }

        private void BBuscarCliente_Click(object sender, EventArgs e)
        {
            BBuscarCliente.Enabled = false;
            string filtro = TBDniSearch.Text.Trim();
            var formBusqueda = new BuscarCliente(filtro);

            formBusqueda.ClienteSeleccionado += (nombre, apellido, dni, domicilio, telefono) =>
            {
                TBNombre.Text = nombre;
                TBApellido.Text = apellido;
                TBDni.Text = dni;
                TBDomicilio.Text = domicilio;
                TBTelefono.Text = telefono;
            };

            formBusqueda.FormClosed += (s, args) => BBuscarProducto.Enabled = true;

            formBusqueda.Show();
        }
    }
}

