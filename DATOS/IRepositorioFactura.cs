using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDADES;


namespace DATOS
{
    public interface IRepositorioFactura
    {
        public void CrearFactura(Factura factura);
        public List<Factura> ConsultarFacturas();
        public Factura ConsultarFactura(int idFactura);
        
    }
}
