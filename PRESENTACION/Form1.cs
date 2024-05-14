using APLICACION;
using ENTIDADES;
using static System.Runtime.InteropServices.JavaScript.JSType;

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

        ServicioProducto servicioProducto = new ServicioProducto();



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
            ValidarCampos();
            Producto productoNuevo = new Producto(referencia,nombre,existencia,stocks,precioUnitarios,estadoProducto);    


            ServicioProducto servicioProducto = new ServicioProducto();

            servicioProducto.CrearProducto(productoNuevo);
            MessageBox.Show("Datos Registrados con exito", "Rgistrado", MessageBoxButtons.OK, MessageBoxIcon.Information); 

    }


        private bool ValidarCampos()
        {
            // Validar cada campo y retornar false si alguno es inválido
            if (string.IsNullOrWhiteSpace(Txt_Referencia.Text))
                MessageBox.Show("La referencia no puede estar vacía");
            if (string.IsNullOrWhiteSpace(Txt_Nombre.Text))
                MessageBox.Show("El nombre no puede estar vacío");
            if (!int.TryParse(Txt_Existencias.Text, out ))
                MessageBox.Show("Las existencias deben ser un valor numérico");
            if (!int.TryParse(Txt_Stock.Text, out ))
                MessageBox.Show("El stock mínimo debe ser un valor numérico");
            if (!decimal.TryParse(Txt_PrecioUnitario.Text, out ))
                MessageBox.Show("El precio unitario debe ser un valor numérico");
            if (Cmb_Estado.SelectedIndex < 0 || Cmb_Estado.SelectedIndex >= Enum.GetNames(typeof(EstadoProducto)).Length)
                MessageBox.Show("Debe seleccionar un estado válido (Activo/Inactivo)");
            //if (servicioProducto.ExisteProducto(Txt_Referencia.Text))
            //    return MostrarError("La referencia del producto ya existe");

            // Si todas las validaciones son correctas, retornar true
            return true;
        }




    }
}
