using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ventas.BL;

namespace ventas
{
    public partial class FormReportedeCompras : Form
    {
        public FormReportedeCompras()
        {
            InitializeComponent();
        }

            public void CargarDatos(ComprasBL comprasBL, ProveedoresBL proveedoresBL)
        {
            var bindingSource = new BindingSource();
            bindingSource.DataSource =
                from o in comprasBL.ListadeCompras
                select new
                {
                    Id = o.Id,
                    Fecha = o.Fecha,
                    Proveedores = proveedoresBL
                         .ListadeProveedores
                         .FirstOrDefault(r => r.Id == o.ProveedoresId)
                         .Nombre,
                    Subtotal = o.Subtotal,
                    Impuesto = o.Impuesto,
                    Total = o.Total,
                    Activo = o.Activo,
                };

            var reporte = new ReportedeCompras();
            reporte.SetDataSource(bindingSource);

            crystalReportViewer1.ReportSource = reporte;
            crystalReportViewer1.RefreshReport();

        }
    }
}
