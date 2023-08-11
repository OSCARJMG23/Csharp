using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ejercioLinQproductos.Clases
{
    public static class Env
    {
        private static string productosFilename = "Productos.json";
        private static string categoriasFilename = "Categorias.json";

        public static List<Productos> Productos { get; set; } = new List<Productos>();
        public static List<Categorias> Categorias { get; set; } = new List<Categorias>();

        public static void LoadDataProducto()
        {
            if (File.Exists(productosFilename))
            {
                string json = File.ReadAllText(productosFilename);
                Productos = System.Text.Json.JsonSerializer.Deserialize<List<Productos>>(json,
                    new System.Text.Json.JsonSerializerOptions() { PropertyNameCaseInsensitive = true }) ?? new List<Productos>();
            }
        }

        public static void SaveDataProducto()
        {
            string json = System.Text.Json.JsonSerializer.Serialize(Productos, new System.Text.Json.JsonSerializerOptions() { WriteIndented = true });
            File.WriteAllText(productosFilename, json);
        }

        // Repetir el patrón para Categorias
        public static void LoadDataCategoria()
        {
            if (File.Exists(categoriasFilename))
            {
                string json = File.ReadAllText(categoriasFilename);
                Categorias = System.Text.Json.JsonSerializer.Deserialize<List<Categorias>>(json,
                    new System.Text.Json.JsonSerializerOptions() { PropertyNameCaseInsensitive = true }) ?? new List<Categorias>();
            }
        }

        public static void SaveDataCategoria()
        {
            string json = System.Text.Json.JsonSerializer.Serialize(Categorias, new System.Text.Json.JsonSerializerOptions() { WriteIndented = true });
            File.WriteAllText(categoriasFilename, json);
        }
    }
}




internal class Program
{
    public static void Main(string[] args)
    {
        Env.LoadDataProducto(); // Cargar datos de productos al inicio
        Env.LoadDataCategoria(); // Cargar datos de categorías al inicio

        // Resto de tu código aquí...

        do
        {
            opcionMenu = menu.mostrarMenu();
            switch (opcionMenu)
            {
                case 1:
                    Productos nuevoProducto = new Productos();
                    nuevoProducto = nuevoProducto.agregarProducto();
                    Env.Productos.Add(nuevoProducto);
                    Env.SaveDataProducto(); // Guardar datos de productos después de agregar
                    break;
                case 2:
                    Categorias nuevaCategoria = new Categorias();
                    nuevaCategoria = nuevaCategoria.agregarCategoria();
                    Env.Categorias.Add(nuevaCategoria);
                    Env.SaveDataCategoria(); // Guardar datos de categorías después de agregar
                    break;
                // Resto de tu código aquí...
            }
        } while (opcionMenu != 6);

        // Al salir del programa, guardar los datos
        Env.SaveDataProducto();
        Env.SaveDataCategoria();
    }

    // Resto de tus métodos listarCategorias, listarProductos, calcularValorInventario...
}