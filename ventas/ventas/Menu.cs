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
    public partial class Menu : Form
    {
        ProductosBL _productosBL;
        CategoriasBL _categoriasBL;
        ClientesBL _clientesBL;
        CiudadBL _ciudadesBL;
        FacturaBL _facturaBL;
        ComprasBL _comprasBL;
        ProveedoresBL _proveedoresBL;
        UsuariosBL _usuariosBL;
       
        
        
        public Menu()
        {
            InitializeComponent();

            _productosBL = new ProductosBL();
            _categoriasBL = new CategoriasBL();
            _clientesBL = new ClientesBL();
            _ciudadesBL = new CiudadBL();
            _facturaBL = new FacturaBL();
            _proveedoresBL = new ProveedoresBL();
            _comprasBL = new ComprasBL();
            _usuariosBL = new UsuariosBL();
            
                    

        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formProductos =  new Form1();
            formProductos.MdiParent = this;
            formProductos.cargarDatos(_productosBL, _categoriasBL);
            formProductos.Show();

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formClientes = new Form2();
            formClientes.MdiParent = this;
            formClientes.cargarDatos(_clientesBL, _ciudadesBL);
            formClientes.Show();
        }

        private void facturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
        var formFactura = new Form3();
        formFactura.MdiParent = this;
        formFactura.cargarDatos(_facturaBL, _clientesBL, _productosBL);
        formFactura.Show();
                     
      
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formProveedores = new Form4();
            formProveedores.MdiParent = this;
            formProveedores.cargarDatos(_proveedoresBL);

            formProveedores.Show();
        }

        private void comprasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var formCompras = new Form5();
            formCompras.MdiParent = this;

            formCompras.cargarDatos(_comprasBL, _proveedoresBL, _productosBL);
            formCompras.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            var login = new Login();
            login.CargarDatos(_usuariosBL);

            login.ShowDialog();

            productosToolStripMenuItem.Visible = login.UsuarioAutenticado.PuedeVerProductos;
            facturaToolStripMenuItem.Visible = login.UsuarioAutenticado.PuedeVerFacturas;
            clientesToolStripMenuItem.Visible = login.UsuarioAutenticado.PuedeVerClientes;

            proveedoresToolStripMenuItem.Visible = login.UsuarioAutenticado.PuedeVerProveedores;
            comprasToolStripMenuItem.Visible = login.UsuarioAutenticado.PuedeVerCompras;

            reportesToolStripMenuItem.Visible = login.UsuarioAutenticado.PuedeVerReportes;
        }

        private void reporteDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formReporteProductos = new FormReporteProductos();
            formReporteProductos.CargarDatos(_productosBL);
            formReporteProductos.MdiParent = this;

            formReporteProductos.Show();
        }

        private void totalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formReportedeVentas = new FormReportedeVentas();
            formReportedeVentas.CargarDatos(_facturaBL, _clientesBL);
            formReportedeVentas.MdiParent = this;

            formReportedeVentas.Show();
        }

        private void porClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formReportedeVentas = new FormReportedeVentas();
            formReportedeVentas.CargarDatos(_facturaBL, _clientesBL);
            formReportedeVentas.MdiParent = this;

            formReportedeVentas.Show();
        }

        private void reporteDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formReportedeClientes = new FormReportedeClientes();
            formReportedeClientes.CargarDatos(_clientesBL);
            formReportedeClientes.MdiParent = this;

            formReportedeClientes.Show();
        }

        private void reporteDeProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formReportedeProveedores = new FormReportedeProveedores();
            formReportedeProveedores.CargarDatos(_proveedoresBL);
            formReportedeProveedores.MdiParent = this;

            formReportedeProveedores.Show();
        }

        private void reporteDeComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formReportedeCompras = new FormReportedeCompras();
            formReportedeCompras.CargarDatos(_comprasBL, _proveedoresBL);
            formReportedeCompras.MdiParent = this;

            formReportedeCompras.Show();
        }
    }
}
