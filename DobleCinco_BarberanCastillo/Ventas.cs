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
using System.Windows.Forms;// Reemplaza el using al inicio del archivo

namespace DobleCinco_BarberanCastillo
{
    public partial class Ventas : Form
    {

        string connectionString = ConfigurationManager.ConnectionStrings["doble_cinco"].ConnectionString;
        int id_vendedor;
        public Ventas()
        {
            InitializeComponent();
            ConfigurarDgvDetalleVenta();
        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            var vendedor = Models.Sesion.UsuarioActual;
            if (vendedor != null)
            {
                id_vendedor = vendedor.Id;
            }
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
            using (SqlConnection outerConn = new SqlConnection(connectionString)) // Renombrado a 'outerConn'
            {
                try
                {
                    if (dgvDetalleVenta.Rows.Count == 0 || dgvDetalleVenta.Rows[0].IsNewRow)
                    {
                        MessageBox.Show("Debe agregar al menos un producto a la venta.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Validar cantidades > 0
                    foreach (DataGridViewRow row in dgvDetalleVenta.Rows)
                    {
                        if (row.IsNewRow) continue;
                        if (!int.TryParse(row.Cells["producto_cantidad"].Value?.ToString(), out int qty) || qty <= 0)
                        {
                            MessageBox.Show("La cantidad de los productos debe ser mayor a cero.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // Obtener id_cliente a partir del DNI mostrado en el formulario
                    if (!int.TryParse(TBDni.Text, out int dniCliente) || dniCliente == 0)
                    {
                        MessageBox.Show("Cliente no seleccionado o DNI inválido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    using (var innerConn = new SqlConnection(connectionString)) // Renombrado a 'innerConn'
                    {
                        innerConn.Open();
                        using (var tran = innerConn.BeginTransaction())
                        {
                            try
                            {
                                // Buscar id_cliente por DNI
                                int idCliente;
                                using (var cmd = new SqlCommand("SELECT id_cliente FROM cliente WHERE dni_cliente = @dni", innerConn, tran))
                                {
                                    cmd.Parameters.AddWithValue("@dni", dniCliente);
                                    var obj = cmd.ExecuteScalar();
                                    if (obj == null)
                                    {
                                        MessageBox.Show("Cliente no encontrado en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        tran.Rollback();
                                        return;
                                    }
                                    idCliente = Convert.ToInt32(obj);
                                }

                                // Insertar venta y obtener id_venta
                                int idVenta;
                                int idForma = 4;
                                using (var cmd = new SqlCommand("INSERT INTO venta (id_usuarios, id_forma, id_cliente) VALUES (@usuario, @forma, @cliente); SELECT CAST(SCOPE_IDENTITY() AS INT);", innerConn, tran))
                                {
                                    cmd.Parameters.AddWithValue("@usuario", id_vendedor);
                                    cmd.Parameters.AddWithValue("@forma", idForma);
                                    cmd.Parameters.AddWithValue("@cliente", idCliente);
                                    idVenta = (int)cmd.ExecuteScalar()!;
                                }

                                using (var cmdDetalle = new SqlCommand("", innerConn, tran))
                                using (var cmdUpdate = new SqlCommand("", innerConn, tran))
                                {
                                    cmdDetalle.CommandText = @"INSERT INTO detalle_ventas (cantidad_detalle, precio_detalle, id_producto, id_ventas, id_cliente)
                                               VALUES (@cantidad, @precio, @idproducto, @idventa, @idcliente)";
                                    cmdDetalle.Parameters.Add(new SqlParameter("@cantidad", System.Data.SqlDbType.Int));
                                    cmdDetalle.Parameters.Add(new SqlParameter("@precio", System.Data.SqlDbType.Float));
                                    cmdDetalle.Parameters.Add(new SqlParameter("@idproducto", System.Data.SqlDbType.Int));
                                    cmdDetalle.Parameters.AddWithValue("@idventa", idVenta);
                                    cmdDetalle.Parameters.AddWithValue("@idcliente", idCliente);

                                    cmdUpdate.CommandText = @"UPDATE producto
                                      SET cantidad_producto = cantidad_producto - @qty
                                      WHERE id_producto = @idproduct AND cantidad_producto >= @qty";

                                    cmdUpdate.Parameters.Add(new SqlParameter("@qty", System.Data.SqlDbType.Int));
                                    cmdUpdate.Parameters.Add(new SqlParameter("@idproduct", System.Data.SqlDbType.Int));

                                    foreach (DataGridViewRow row in dgvDetalleVenta.Rows)
                                    {
                                        if (row.IsNewRow) continue;
                                        int idProd = Convert.ToInt32(row.Cells["id_producto"].Value);
                                        int cantidad = Convert.ToInt32(row.Cells["producto_cantidad"].Value);
                                        decimal precio = Convert.ToDecimal(row.Cells["producto_precio"].Value);

                                        cmdUpdate.Parameters["@qty"].Value = cantidad;
                                        cmdUpdate.Parameters["@idproduct"].Value = idProd;
                                        int updated = cmdUpdate.ExecuteNonQuery();
                                        if (updated == 0)
                                        {
                                            MessageBox.Show($"Stock insuficiente para el producto ID {idProd}.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                            tran.Rollback();
                                            return;
                                        }

                                        cmdDetalle.Parameters["@cantidad"].Value = cantidad;
                                        cmdDetalle.Parameters["@precio"].Value = (double)precio;
                                        cmdDetalle.Parameters["@idproducto"].Value = idProd;
                                        cmdDetalle.ExecuteNonQuery();
                                    }
                                }

                                tran.Commit();
                                MessageBox.Show("Venta registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Limpiar UI si procede
                                dgvDetalleVenta.Rows.Clear();
                                TBNombre.Clear();
                                TBApellido.Clear();
                                TBDni.Clear();
                                TBDomicilio.Clear();
                                TBTelefono.Clear();
                            }
                            catch (Exception ex)
                            {
                                try { tran.Rollback(); } catch { }
                                MessageBox.Show("Error al guardar la venta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al realizar venta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

