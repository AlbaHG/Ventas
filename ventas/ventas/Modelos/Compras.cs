﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ventas.BL;

namespace ventas.Modelos
{
    public class Compras
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }

        public int ProveedoresId { get; set; }
        public Proveedores Proveedores { get; set; }

        public double Subtotal { get; set; }
        public double Impuesto { get; set; }
        public double Total { get; set; }

        public bool Activo { get; set; }

        public BindingList<ComprasDetalle> ComprasDetalle { get; set; }

        public Compras()
        {
            Fecha = DateTime.Now;
            Activo = true;
            ComprasDetalle = new BindingList<ComprasDetalle>();
        }

        public void CalcularTotalCompras()
        {
            var productosBL = new ProductosBL();

            double subtotal = 0;
            foreach (var detalle in ComprasDetalle)
            {
                var costo = productosBL.ObtenerCosto(detalle.ProductoId);

                subtotal = subtotal + detalle.CalcularTotalDetalle(costo);
            }

            Subtotal = subtotal;
            Impuesto = Subtotal * 0.15;
            Total = Subtotal + Impuesto;

        }

    }
    public class ComprasDetalle
    {
        public int Id { get; set; }

        public int ProductoId { get; set; }
        public Productos productos { get; set; }

        public int Cantidad { get; set; }
        public double Costo { get; set; }
        public double Total { get; set; }

        public ComprasDetalle()
        {
            Cantidad = 1;
            ProductoId = 1;
        }
        public double CalcularTotalDetalle(double costo)
        {
            Costo = costo;
            Total = Cantidad * Costo;

            return Total;
        }
    }
}



