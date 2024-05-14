using ENTIDADES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATOS;

namespace APLICACION
{
    public class ServicioProducto : IServicioPRoducto
    {
       RepositorioProducto repositorio = new RepositorioProducto();


        public Producto ConsultarProducto(string referencia)
        {

            return repositorio.EncontrarProducto(referencia);


        }
        
        public List<Producto> ConsultarProductos()
        {


            var productos = repositorio.EncontrarProductos();
            return productos;


        }

        public void CrearProducto(Producto producto)
        {

            repositorio.Registrar(producto);



        }
    }
}
