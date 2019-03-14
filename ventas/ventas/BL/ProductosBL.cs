using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ventas.Modelos;

namespace ventas.BL
{
    public class ProductosBL
    {
        public BindingList<Productos> ListadeProductos { get; set; }

        public ProductosBL()
        {
            ListadeProductos = new BindingList<Productos>();
            CrearDatosdePrueba();
        }

        public double ObtenerPrecio(int id)
        {
            double precio = 0;

            foreach (var productos in ListadeProductos)
            {
              if (productos.Id == id)
                {
                    precio = productos.Precio;
                }
            }

            return precio;
        }

        private void CrearDatosdePrueba()
        {
            var categoria1 = new Categoria(1, "Laptos");
            var categoria2 = new Categoria(2, "Accesorios");

            var producto1 = new Productos(1, "Laptop Dell", 15000, categoria1);
            var producto2 = new Productos(2, "Laptop Asus", 20000, categoria1);
            var producto3 = new Productos(3, "Mouse Logitech", 200, categoria2);

            ListadeProductos.Add(producto1);
            ListadeProductos.Add(producto2);
            ListadeProductos.Add(producto3);
        }
    }
}
