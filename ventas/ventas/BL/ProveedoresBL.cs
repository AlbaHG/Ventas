using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ventas.Modelos;

namespace ventas.BL
{
    public class ProveedoresBL
    {
        public BindingList<Proveedores> ListadeProveedores { get; set; }

        public ProveedoresBL()
        {
            ListadeProveedores = new BindingList<Proveedores>();
            CrearDatosdePrueba();

        }
              
        private void CrearDatosdePrueba()
        {
            var categoria1 = new Categoria(1, "Nombres");
            var categoria2 = new Categoria(2, "Ciudades");

            var proveedor1 = new Proveedores(123, "Sycom", 99473142, "Tijuana", "Tijuana, Mexico", categoria1);
            var proveedor2 = new Proveedores(222, "Office", 99339944, "SPS", "SPS, Honduras", categoria2);
            var proveedor3 = new Proveedores(333, "Indu", 99112233, "Guatemala", "Guatemala", categoria2);

            ListadeProveedores.Add(proveedor1);
            ListadeProveedores.Add(proveedor2);
            ListadeProveedores.Add(proveedor3);
        }
     }
 }
