using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ejercicioLinQProductosJson.Entities
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }


        public static void addCategoria()
        {
            Categoria cat = new Categoria();
            Console.Write("Ingrese le ID de la categoria");
            cat.Id = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el nombre de la categoria");
            cat.Descripcion = Console.ReadLine();
            Env.TiendaCampus.Categorias.Add(cat);
        }
        public IEnumerable<Categoria>ListaCategorias(){
            return from cat in Env.TiendaCampus.Categorias
                select cat;
        }
    }
}