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
    public partial class FormReportedeProveedores : Form
    {
        public FormReportedeProveedores()
        {
            InitializeComponent();
        }

        public void CargarDatos(ProveedoresBL proveedoresBL)
        {
            // var bindingSoure = new BindingSource();
            // bindingSoure.DataSource = proveedoresBL.ListadeProveedores;

            
            var bindingSource = new BindingSource();
            bindingSource.DataSource =
                from x in proveedoresBL.ListadeProveedores
                select new
                {
                    Foto = x.Foto,
                    Id = x.Id,
                    Nombre = x.Nombre,
                    Telefono = x.Telefono,
                  
                };

            var reporte = new ReportedeProveedores();
            reporte.SetDataSource(bindingSource);

            crystalReportViewer1.ReportSource = reporte;
            crystalReportViewer1.RefreshReport();
        }
    }
}
