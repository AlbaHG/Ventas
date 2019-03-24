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
using ventas.Modelos;

namespace ventas
{
    public partial class Form4 : Form
    {
       ComprasBL _comprasBL;

        public Form4()
        {
            InitializeComponent();
        }
        public void cargarDatos(ComprasBL comprasBL, ProveedoresBL proveedoresBL, InventarioBL inventarioBL)
        //private void Form4_Load(object sender, EventArgs e)
      
        {
            _comprasBL = comprasBL; 

            listadeComprasBindingSource.DataSource = comprasBL.ListadeCompras;
            listadeProveedoresBindingSource.DataSource = proveedoresBL.ListadeProveedores;
            listadeInventarioBindingSource.DataSource = inventarioBL.ListadeInventario;
              
       
        }

       private void comprasDetalleDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
          var compras = (Compras)listadeComprasBindingSource.Current;
         compras.CalcularTotalCompras();

            listadeComprasBindingSource.ResetBindings(false);
        }

            private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        internal void cargarDatos(InventarioBL _inventarioBL, CategoriasBL _categoriasBL)
        {
          throw new NotImplementedException();
     }

     internal void cargarDatos(ProveedoresBL _proveedoresBL, CiudadBL _ciudadBL)
       {
          throw new NotImplementedException();
        }
   }
}
