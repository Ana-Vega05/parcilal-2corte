using ENTIDADES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;






namespace DATOS
{
    public interface IRepositorioProducto
    {
            public void Registrar(Producto producto);
            public Producto EncontrarProducto(string referencia);
            public List<Producto> EncontrarProductosPorEstado(string estado);
            public List<Producto> EncontrarProductosPornombre(string nombre);

            public void EliminarProducto(Producto producto);
        

    }
}
