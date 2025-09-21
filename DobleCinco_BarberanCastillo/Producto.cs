using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DobleCinco_BarberanCastillo
{
    public partial class Producto : Form
    {
        public Producto()
        {
            InitializeComponent();
            BProducto_agregar.Click += BProducto_agregar_Click;
            BAgregarImagen.Click += BAgregarImagen_Click;
        }

        private void Producto_Load(object sender, EventArgs e)
        {

        }

        private void TBStockMinimo_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TBVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.')
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

        private void LCategoria_Click(object sender, EventArgs e)
        {

        }

        private void LMinimo_Click(object sender, EventArgs e)
        {

        }

        private void LNombre_Click(object sender, EventArgs e)
        {

        }

        private void TBNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void LDescripcion_Click(object sender, EventArgs e)
        {

        }

        private string rutaImagenProducto = "";

       

        private void BProducto_agregar_Click(object sender, EventArgs e)
        {
            int id = dataGridView1.Rows.Count + 1;
            Image img = PBproducto_imagen.Image != null ? (Image)PBproducto_imagen.Image.Clone() : null;

            dataGridView1.Rows.Add(
                id, // id_producto
                TBNombre.Text,
                TBDescripcion.Text,
                TBCosto.Text,
                TBVenta.Text,
                TBStock.Text,
                TBStockMinimo.Text,
                CBCategoria.SelectedItem != null ? CBCategoria.SelectedItem.ToString() : "",
                img // Imagen
            );
        }

        private void TBStockMinimo_TextChanged(object sender, EventArgs e)
        {

        }

        private void BAgregarImagen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    PBproducto_imagen.Image = Image.FromFile(ofd.FileName);
                    rutaImagenProducto = ofd.FileName; // Guarda la ruta para usarla después
                }
            }
        }
    }

}


