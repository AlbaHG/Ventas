using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ventas.Modelos;

namespace ventas.BL
{
   public  class ProveedoresBL
    {
        public BindingList<Proveedores> ListadeProveedores { get; set; }


        public ProveedoresBL()
        {
            ListadeProveedores = new BindingList<Proveedores>();
            CrearDatosdePrueba();
        }


        public void CrearDatosdePrueba()
        {
            var proveedores1 = new Proveedores(111, "Mario", 89764532);
            var proveedores2 = new Proveedores(112, "Jorge", 7664362);
            var proveedores3 = new Proveedores(113, "Bily", 89764534);


            ListadeProveedores.Add(proveedores1);
            ListadeProveedores.Add(proveedores2);
            ListadeProveedores.Add(proveedores3);
        }
    }
}
