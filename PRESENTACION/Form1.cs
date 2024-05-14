using APLICACION;
using ENTIDADES;

namespace PRESENTACION
{
    public partial class Form1 : Form
    {
        private List<DetalleFactura> Detalles = new List<DetalleFactura>();
        private IServicioFactura ServicioFactura = new ServicioFactura();
        private IServicioProducto ServicioProducto = new ServicioProducto();

        public Form1()
        {
            InitializeComponent();
            InitializeComboBox();
            LlenarTablaDetalles();
            LlenarTablaProductos();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var cantidad = int.Parse(cantidadTxt.Text);
            foreach (DataGridViewRow item in detallesDtG.Rows)
            {
                var productoSeleciconado = (bool?)item.Cells[0].Value;
                if (productoSeleciconado != null && productoSeleciconado == true)
                {
                    var referenciaProducto = item.Cells[1].Value.ToString();
                    var nombreProducto = item.Cells[2].Value.ToString();
                    var stockProducto = int.Parse(item.Cells[3].Value.ToString());
                    var precioUnitarioProducto = double.Parse(item.Cells[4].Value.ToString());
                    if (stockProducto < cantidad)
                    {
                        cantidad = stockProducto;
                        // TODO: MOSTRAR MENSAJE
                    }

                    var detalle = new DetalleFactura(0, cantidad, nombreProducto, referenciaProducto, precioUnitarioProducto);
                    Detalles.Add(detalle);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int idFactura = int.Parse(idFacturaTxt.Text);
                DateTime fechaFactura = DateTime.Parse(fechaFacturaDate.Text);
                Factura factura = new Factura(idFactura, fechaFactura);
                factura.DetallesFactura = Detalles;
                ServicioFactura.CrearFactura(factura);
                foreach (var producto in Detalles)
                {
                    ServicioProducto.DescontarCantidad(producto.ReferenciaProducto, producto.Cantidad);
                }
                LlenarTablaDetalles();
                LlenarTablaProductos();
                Limpiar();
            }
            catch (Exception)
            {
                // TODO: MOSTRAR NOTIFICACION DE QUE LA FECHA DEBE SER MAYOR
            }
        }

        private void Limpiar()
        {
            idFacturaTxt.Text = string.Empty;
            fechaFacturaDate.Text = string.Empty;
            cantidadTxt.Text = string.Empty;
        }

        private void LlenarTablaDetalles()
        {
            detallesDtG.Rows.Clear();
            List<Producto> productos = ServicioProducto.ConsultarProductos();
            foreach (Producto producto in productos)
            {
                int rowIndex = detallesDtG.Rows.Add();
                DataGridViewRow row = detallesDtG.Rows[rowIndex];
                row.Cells[1].Value = producto.Referencia;
                row.Cells[2].Value = producto.Nombre;
                row.Cells[3].Value = producto.Existencias;
                row.Cells[4].Value = producto.PrecioUnitario;
            }
        }

        private void LlenarTablaProductos()
        {
            dataGridView1.Rows.Clear();
            List<Producto> productos = ServicioProducto.ConsultarProductos();
            foreach (Producto producto in productos)
            {
                int rowIndex = dataGridView1.Rows.Add();
                DataGridViewRow row = dataGridView1.Rows[rowIndex];
                row.Cells[1].Value = producto.Referencia;
                row.Cells[2].Value = producto.Nombre;
                row.Cells[3].Value = producto.Existencias;
                row.Cells[4].Value = producto.PrecioUnitario;
            }
        }

        private void InitializeComboBox()
        {
            Cmb_Estado.Items.AddRange(Enum.GetNames(typeof(EstadoProducto)));
        }



        private void Btn_Guardar_Click(object sender, EventArgs e)
        {

            string referencia = Txt_Referencia.Text;

            string nombre = Txt_Nombre.Text;
            int existencia = int.Parse(Txt_Existencias.Text);
            int stocks = int.Parse(Txt_Stock.Text);
            int precioUnitarios = int.Parse(Txt_PrecioUnitario.Text);
            EstadoProducto estadoProducto = (EstadoProducto)Cmb_Estado.SelectedIndex;

            Producto productoNuevo = new Producto(referencia, nombre, existencia, stocks, precioUnitarios, estadoProducto);


            ServicioProducto servicioProducto = new ServicioProducto();

            servicioProducto.CrearProducto(productoNuevo);
            MessageBox.Show("Datos Registrados con exito", "Rgistrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LlenarTablaProductos();
            LlenarTablaDetalles();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
