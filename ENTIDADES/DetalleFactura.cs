﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES
{
    public class DetalleFactura
    {
        public int idDetalle { get; set; }
        public int Cantidad { get; set; }
        public string NombreProducto { get; set; }
        public string ReferenciaProducto { get; set; }
        public double PrecioUnitarioProducto { get; set; }
        public double ValorItemVendido => PrecioUnitarioProducto * Cantidad;

        public DetalleFactura(int idDetalle, int cantidad, string nombreProducto, string referenciaProducto, double precioUnitarioProducto)
        {
            this.idDetalle = idDetalle;
            Cantidad = cantidad;
            NombreProducto = nombreProducto;
            ReferenciaProducto = referenciaProducto;
            PrecioUnitarioProducto = precioUnitarioProducto;
        }

        public override string ToString()
        {
            return $"{idDetalle},{ReferenciaProducto},{NombreProducto},{Cantidad},{PrecioUnitarioProducto}";
        }
    }


}
