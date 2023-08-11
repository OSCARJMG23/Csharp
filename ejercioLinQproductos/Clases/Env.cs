using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ejercioLinQproductos.Clases
{
    public static class Env
    {
        private static string filename = "Productos.json";
        private static List<Productos> Productos = new List<Productos>();

        public static string FileName {get => filename; set => filename = value;}
        public static List<Productos> Productos {get => Productos; set => Productos = value;}


        public static void LoadDataProducto()
        {
            using (StreamReader reader = new StreamReader(Env.FileName))
            {
                string json = reader.ReadToEnd();
                Env.Productos = System.Text.Json.JsonSerializer.Deserialize<List<Productos>>(json, new System.Text.Json.JsonSerializerOptions()
                {PropertyNameCaseInsensitive = true}) ?? new List<Productos>();
            }
        }
    }
}