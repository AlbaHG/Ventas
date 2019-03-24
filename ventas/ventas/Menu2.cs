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
    public partial class Menu2 : Form
    {
        InventarioBL _inventarioBL;
        CategoriasBL _categoriaBL;
        ProveedoresBL _proveedoresBL;
        CiudadBL _ciudadBL;
        ComprasBL _comprasBL; 

        public Menu2()
        {
            InitializeComponent();

            _inventarioBL = new InventarioBL();
            _categoriaBL = new CategoriasBL();
            _proveedoresBL = new ProveedoresBL();
            _ciudadBL = new CiudadBL();
            _comprasBL = new ComprasBL();
        }

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formInventario = new Form4();
            formInventario.MdiParent = this;
            formInventario.Show();
      
     

        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formProveedores = new Form4();
            formProveedores.MdiParent = this;

            formProveedores.cargarDatos(_proveedoresBL, _ciudadBL);

            formProveedores.Show();
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formCompras = new Form4();
            formCompras.MdiParent = this;

            formCompras.cargarDatos(_comprasBL, _proveedoresBL, _inventarioBL);

            formCompras.Show();
        }
    }
}
