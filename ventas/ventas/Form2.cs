using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ventas
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Categorias
            var categoria1 = new Categoria();
            categoria1.Id = 1;
            categoria1.Nombre = "Castellanos";

            var categoria2 = new Categoria();
            categoria2.Id = 2;
            categoria2.Nombre = "Carlos R";

            var categoria3 = new Categoria();
            categoria3.Id = 3;
            categoria3.Nombre = "Valentina";

            //Clientes
            var cliente1 = new Cliente();
            cliente1.Id = 1;
            cliente1.Nombre = "Castellanos";
            cliente1.Telefono = 99944422;
            cliente1.Ciudad = "Paris";
            cliente1.Direccion = "Paris, Francia";
            cliente1.categoria = categoria1;

            Cliente cliente2 = new Cliente();
            cliente2.Id = 2;
            cliente2.Nombre = "Carlos R";
            cliente2.Telefono = 99887766;
            cliente2.Ciudad = "SPS";
            cliente2.Direccion = "San Pedro Sula, Cortes Honduras";
            cliente2.categoria = categoria2;


            Cliente cliente3 = new Cliente();
            cliente3.Id = 3;
            cliente3.Nombre = "Valentina";
            cliente3.Telefono = 333344552;
            cliente3.Ciudad = "Madrid";
            cliente3.Direccion = "España";
            cliente3.categoria = categoria3;


            var listadeClientes = new List<Cliente>();
            listadeClientes.Add(cliente1);
            listadeClientes.Add(cliente2);
            listadeClientes.Add(cliente3);

            foreach (var C in listadeClientes)
            {
                MessageBox.Show(C.Nombre + " " + C.Ciudad );
                
            }

        }
    }
}
