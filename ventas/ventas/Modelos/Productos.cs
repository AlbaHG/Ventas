using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ventas.Modelos;

namespace ventas.Modelos
{
     public class Productos
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public double Costo { get; set; }
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
        public byte[] Foto { get; set; }
        public int Existencia { get; set; }

        public Productos()
        {
            Categoria = new Categoria(1, "Laptops");
            CategoriaId = Categoria.Id;
         }

         public Productos(int id, string descripcion, double precio, double costo, Categoria categoria)
        {
            Id = id;
            Descripcion = descripcion;
            Precio = precio;
            Costo = costo;
            Categoria = categoria;
            CategoriaId = categoria.Id;
            //Existencia = existencia;

        }
    }
}
