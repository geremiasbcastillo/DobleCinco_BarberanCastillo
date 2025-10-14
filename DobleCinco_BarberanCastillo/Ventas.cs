using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DobleCinco_BarberanCastillo
{
    public partial class Ventas : Form
    {
        public Ventas()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void LVentas_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LBuscar_Click(object sender, EventArgs e)
        {

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

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BBuscarProducto_Click(object sender, EventArgs e)
        {
            // 1. Obtenemos el texto del campo de descripción para usarlo como filtro
            string filtro = TBDescripcion.Text.Trim();

            // 2. Creamos una instancia del formulario de búsqueda y le pasamos el filtro
            using (var formBusqueda = new BuscarProducto(filtro))
            {
                // 3. Mostramos el formulario como un diálogo. El código aquí se detiene hasta que el pop-up se cierre.
                var resultado = formBusqueda.ShowDialog();

                // 4. Verificamos si el usuario presionó "Seleccionar"
                if (resultado == DialogResult.OK)
                {
                    // 5. Obtenemos los datos del producto desde las propiedades públicas del formulario de búsqueda
                    int id = formBusqueda.IdProductoSeleccionado;
                    string descripcion = formBusqueda.DescripcionProducto;
                    decimal precio = formBusqueda.PrecioCostoProducto; // Obtenemos la cantidad del NumericUpDown

                    // 6. Agregamos el producto al DataGridView de la venta
                    dgvDetalleVenta.Rows.Add(id, descripcion, precio);

                    // Limpiamos los campos para la siguiente búsqueda
                    TBDescripcion.Clear();
                    TBDescripcion.Focus();
                }
            }
        }
    }
}

