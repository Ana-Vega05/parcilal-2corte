using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ENTIDADES
{
    public class Producto
    {
        public string Referencia { get; set; }
        public string Nombre { get; set; }
        public int Existencias { get; set; }
        public int StockMinimo { get; set; }
        public decimal PrecioUnitario { get; set; }
        public EstadoProducto EstadoProducto { get; set; }

        public Producto()
        {

        }

        public Producto(string referencia, string nombre, int existencias, int stockMinimo, decimal precioUnitario, EstadoProducto estadoProducto)
        {
            Referencia = referencia;
            Nombre = nombre;
            Existencias = existencias;
            StockMinimo = stockMinimo;
            PrecioUnitario = precioUnitario;
            EstadoProducto = estadoProducto;
        }

        public void DescontarCantidad(int cantidad)
        {
            if (cantidad >= Existencias)
            {
                Existencias = 0;
            }
            else
            {
                Existencias -= cantidad;
            }
        }


        public override string ToString()
        {
            return $"{Referencia},{Nombre},{Existencias},{StockMinimo},{PrecioUnitario},{(int)EstadoProducto}";
        }


    }
 }

