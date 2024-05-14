using APLICACION;
using ENTIDADES;

namespace PRESENTACION
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeComboBox();
            CargarDatosTabla();
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

            Producto productoNuevo = new Producto(referencia,nombre,existencia,stocks,precioUnitarios,estadoProducto);    


            ServicioProducto servicioProducto = new ServicioProducto();

            servicioProducto.CrearProducto(productoNuevo);
            MessageBox.Show("Datos Registrados con exito", "Rgistrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            

        }

        private void CargarDatosTabla()
        {
            ServicioProducto servicioProducto = new ServicioProducto();
            var productos = servicioProducto.ConsultarProductos();
            Dtg_Productos.Rows.Clear();
            foreach (var producto in productos)
            {
                Dtg_Productos.Rows.Add(producto.Referencia, producto.Nombre, Txt_Existencias, producto.StockMinimo, producto.PrecioUnitario, producto.EstadoProducto);
            }
        }






    }
}
