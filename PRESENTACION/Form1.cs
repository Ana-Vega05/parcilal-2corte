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
            LlenarTabla();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var cantidad = int.Parse(cantidadTxt.Text);
            foreach (DataGridViewRow item in detallesDtG.Rows)
            {
                var productoSeleciconado = (bool?)item.Cells[0].Value;
                if (productoSeleciconado != null && productoSeleciconado == true)
                {
                    var referenciaProducto = int.Parse(item.Cells[1].Value.ToString());
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
                LlenarTabla();
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

        private void LlenarTabla()
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
    }
}
