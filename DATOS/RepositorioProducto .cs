using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDADES;

namespace DATOS
{
    public class RepositorioProducto : IRepositorioProducto
    {
      

        private const string FilePath = "./Productos.csv";



        public new void Registrar(Producto producto)
        {
            FileStreamOptions opciones = new FileStreamOptions()
            {
                Mode = FileMode.Append,
                Access = FileAccess.Write,
            };

            StreamWriter escribir = new StreamWriter(FilePath, opciones);
            escribir.WriteLine(producto.ToString());
            escribir.Close();
        }

        private Producto MapearProducto(string[]? valorLineas)
        {
            var referencia = valorLineas[0];
            var nombre = valorLineas[1];
            var existencia = int.Parse(valorLineas[2]);
            var stockMin = int.Parse(valorLineas[3]);
            var precioUnitario = int.Parse(valorLineas[4]);
            var estado = (EstadoProducto)int.Parse(valorLineas[5]);
            var producto = new Producto(referencia, nombre, existencia, stockMin, precioUnitario, estado);
            return producto;

        }


        public Producto EncontrarProducto(string referencia)
        {
            var productos = EncontrarProductos();
            var productoDeseado = productos.FirstOrDefault(producto => producto.Referencia == referencia);
            return productoDeseado;
        }

        public new List<Producto> EncontrarProductos()
        {
            try
            {
                var productos = new List<Producto>();
                var options = new FileStreamOptions()
                {
                    Access = FileAccess.Read
                };
                using var reader = new StreamReader(FilePath, options);
                var line = reader.ReadLine();
                while (line != null)
                {
                    var lineValues = line.Split(',');
                    Producto producto = MapearProducto(lineValues);
                    productos.Add(producto);
                    line = reader.ReadLine();
                }
                return productos;
            }
            catch (Exception)
            {

                return new List<Producto>();
            }
        }











    }





}

