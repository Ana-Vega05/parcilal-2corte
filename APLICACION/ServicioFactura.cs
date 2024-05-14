using DATOS;
using ENTIDADES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APLICACION
{
    public class ServicioFactura : IServicioFactura
    {
        public IRepositorioFactura Repositorio = new RepositorioFactura();
        public Factura ConsultarFactura(int idFactura)
        {
            return Repositorio.ConsultarFactura(idFactura);
        }

        public List<Factura> ConsultarFacturas()
        {

            return Repositorio.ConsultarFacturas();
        }

        public void CrearFactura(Factura factura)
        {
            var ultimaFactura = ConsultarFacturas().LastOrDefault();
            if (factura.Fechafactura >= ultimaFactura.Fechafactura)
            {
                throw new Exception($"La fecha de la factura debe ser mayor o igual a {ultimaFactura.Fechafactura}");
            }
            Repositorio.CrearFactura(factura);
            foreach (var detalle in factura.DetallesFactura)
            {
                // TODO: DESCONTAR CANTIDADES DE PRODUCTOS
            }
        }
        
    }
}
