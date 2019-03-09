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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            var clientesBl = new ClientesBL();
            listadeClientesBindingSource.DataSource = clientesBl.ListadeClientes;

            var ciudadesBL = new CiudadBL();
            listadeCiudadesBindingSource.DataSource = ciudadesBL.ListadeCiudades;
            
             }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
    }

