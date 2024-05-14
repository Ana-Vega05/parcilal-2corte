using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES
{
    public class Factura
    {
        public int idfactura { get; set; }
        public  DateTime Fechafactura { get; set; }
        public double ValorTotal => CalcularValorTotal();
        public List<DetalleFactura> DetallesFactura { get; set; }

        private double CalcularValorTotal()
        {
            double valorTotal = 0;
            foreach (var detalle in DetallesFactura)
            {
                valorTotal += detalle.ValorItemVendido;
            }
            return valorTotal;
        }

        public Factura(int idfactura, DateTime fechafactura)
        {
            this.idfactura = idfactura;
            Fechafactura = fechafactura;
        }

        public override string ToString()
        {
            return $"{idfactura},{Fechafactura},{ValorTotal}";

        }
    }
}
