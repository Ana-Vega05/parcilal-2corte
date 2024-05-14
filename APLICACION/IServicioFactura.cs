using ENTIDADES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APLICACION
{
    public interface IServicioFactura
    {
        public void CrearFactura(Factura factura);
        public List<Factura> ConsultarFacturas();
        public Factura ConsultarFactura(int idFactura);

    }
}
