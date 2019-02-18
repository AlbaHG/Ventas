using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ventas
{
   public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Telefono { get; set; }
        public string Ciudad { get; set; }
        public string Direccion { get; set; }
        public Categoria categoria { get; set; }
    }
}
