using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ejercioLinQproductos.Clases
{
    public class Categorias
    {
        public int Id {get; set;}
        public string Descripcion {get; set;}

        public Categorias () {  }

        public Categorias agregarCategoria()
        {
            Categorias categoria = new Categorias();
            Console.Write("Ingrese el ID de la categoria: ");
            categoria.Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la descripción de la nueva categoría");
            categoria.Descripcion=Console.ReadLine().TrimEnd();
            return categoria;
        }
    }
}