using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ventas.Modelos;

namespace ventas.BL
{
    public class InventarioBL
    {
        public BindingList<Inventario> ListadeInventario { get; set; }

        public InventarioBL()
        {
            ListadeInventario = new BindingList<Inventario>();
            CrearDatosdePrueba();
        }
             public double ObtenerCosto(int id)
        {
            double costo = 0;

            foreach (var inventario in ListadeInventario)
            {
              if (inventario.Id == id)
                {
                    costo = inventario.Costo;
                }
            }

            return costo;
        }

    
    private void CrearDatosdePrueba()
        {
            var categoria1 = new Categoria(1, "Sycom");
            var categoria2 = new Categoria(2, "Accesorios");

            var inventario1 = new Inventario(1, "Laptop HP", 12000, categoria1);
            var inventario2 = new Inventario(2, "Laptop Toshiba", 15000, categoria1);
            var inventario3 = new Inventario(3, "Auriculares", 500, categoria2);

            ListadeInventario.Add(inventario1);
            ListadeInventario.Add(inventario2);
            ListadeInventario.Add(inventario3);
        }
    }
}
