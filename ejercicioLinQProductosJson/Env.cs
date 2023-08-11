using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ejercicioLinQProductosJson.Entities;
using System.Text.Json;
using Newtonsoft.Json;

namespace ejercicioLinQProductosJson
{
    public class Env
    {
        private static string filename = "Productos.json";
        private static TiendaCampus tiendaCampus = new TiendaCampus();

        public static string FileName {get => filename; set => filename = value;}
        public static TiendaCampus TiendaCampus {get => tiendaCampus; set => tiendaCampus = value;}


        public static void LoadDataProductos(string nombreArchivo)
        {
            string json;
            using (StreamReader reader = File.OpenText(nombreArchivo)){
                json = reader.ReadToEnd();
                TiendaCampus = JsonConvert.DeserializeObject<TiendaCampus>(json) ?? new TiendaCampus();
            }
        }
            
        public static bool ValidarFile(string filename){
            if(!File.Exists(filename))
            {
                return false;
            }
            return true;
        }
        public static void ImprimirDAta<T>(string titulo, IEnumerable<T>lista){
            Console.Write("{0,30}", titulo);
            foreach(var elemento in lista)
            {
                Type tipoClase = elemento.GetType();
                var propiedades = tipoClase.GetProperties();
                foreach(var propiedad in propiedades)
                {
                    Console.WriteLine($"{propiedad.Name}: {propiedad.GetValue(elemento)}");
                }
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            Console.ReadKey();
        }
    }
}