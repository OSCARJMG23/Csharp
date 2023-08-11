using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ejercicioLinQProductosJson.Entities
{
    public class TiendaCampus
    {
        public  List<Producto> Productos = new List<Producto>();
        public  List<Categoria> Categorias = new List<Categoria>();

        public TiendaCampus() { }
    }
}