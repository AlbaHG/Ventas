using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ventas.Modelos;

namespace ventas.Modelos
{
     public class Inventario
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public double Costo { get; set; }
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }

         public Inventario()
        {
            Categoria = new Categoria(1, "Laptops");
            CategoriaId = Categoria.Id;
         }

         public Inventario(int id, string descripcion, double costo, Categoria categoria)
        {
            Id = id;
            Descripcion = descripcion;
            Costo = costo;
            Categoria = categoria;
            CategoriaId = categoria.Id;

        }
    }
}
