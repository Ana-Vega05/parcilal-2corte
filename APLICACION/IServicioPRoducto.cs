using ENTIDADES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APLICACION
{
    public interface IServicioPRoducto
    {

        public void CrearProducto(Producto producto);
        public List<Producto> ConsultarProductos();
        public Producto ConsultarProducto(string referencia);






    }
}
