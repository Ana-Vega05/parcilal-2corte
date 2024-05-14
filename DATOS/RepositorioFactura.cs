using ENTIDADES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATOS
{
    public class RepositorioFactura : IRepositorioFactura
    {
        private const string FilePath = "./Facturas.csv";
        private const string DetallesFilePath = "./DetalleFactura.csv";

        public void CrearFactura(Factura factura)
        {
            FileStreamOptions options = new FileStreamOptions()
            {
                Mode = FileMode.Append,
                Access = FileAccess.Write
            };
            StreamWriter writer = new StreamWriter(FilePath, options);
            writer.WriteLine(factura.ToString());
            writer.Close();
            CrearDetalleFactura(factura.idfactura, factura.DetallesFactura);
        }

        private void CrearDetalleFactura(int idFactura, List<DetalleFactura> detalles)
        {
            FileStreamOptions options = new FileStreamOptions()
            {
                Mode = FileMode.Append,
                Access = FileAccess.Write
            };
            StreamWriter writer = new StreamWriter(DetallesFilePath, options);
            
            foreach (var detalle in detalles)
            {
                writer.WriteLine(detalle.ToString()+ $",{idFactura}");
            }
            writer.Close();
        }
        public Factura ConsultarFactura(int idFactura)
        {
            var facturas = ConsultarFacturas();
            var facturaDeseada = facturas.FirstOrDefault(factura => factura.idfactura == idFactura);
            return facturaDeseada;
        }

        public List<Factura> ConsultarFacturas()
        {
            try
            {
                var facturas = new List<Factura>();
                var options = new FileStreamOptions()
                {
                    Access = FileAccess.Read
                };
                using var reader = new StreamReader(FilePath, options);
                var line = reader.ReadLine();
                while (line != null)
                {
                    var lineValues = line.Split(',');
                    Factura factura = MapearFactura(lineValues);
                    facturas.Add(factura);
                    line = reader.ReadLine();
                }
                return facturas;
            }
            catch (Exception)
            {
                return new List<Factura>();
            }
        }

        public Factura MapearFactura(string[] lineValues)
        {
            var idFactura = int.Parse(lineValues[0]);
            var fechaFactura = DateTime.Parse(lineValues[1]);
            Factura factura = new Factura(idFactura, fechaFactura);
            factura.DetallesFactura = ConsultarDetalleFactura(factura.idfactura);
            return factura;
        }


        public List<DetalleFactura> ConsultarDetalleFactura(int idFactura)
        {
            var detallesFactura = new List<DetalleFactura>();
            var options = new FileStreamOptions()
            {
                Access = FileAccess.Read
            };
            using var reader = new StreamReader(FilePath, options);
            var line = reader.ReadLine();
            while (line != null)
            {
                var lineValues = line.Split(',');
                var idFacturaEncontrada = int.Parse(lineValues[5]);
                if (idFacturaEncontrada == idFactura)
                {
                    DetalleFactura detalleFactura = MapearDetalleFactura(lineValues);
                    detallesFactura.Add(detalleFactura);
                }
                line = reader.ReadLine();
            }
            return detallesFactura;
        }

        public DetalleFactura MapearDetalleFactura(string[]? lineValues)
        {
            var idDetalle = int.Parse(lineValues[0]);
            var referenciaProducto = lineValues[1];
            var nombreProducto = lineValues[2];
            var cantidadProducto = int.Parse(lineValues[3]);
            var precioProducto = double.Parse(lineValues[4]);
            DetalleFactura detalle = new DetalleFactura(idDetalle, cantidadProducto, nombreProducto, referenciaProducto, precioProducto);
            return detalle;
        }

    }
}
