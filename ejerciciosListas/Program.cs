using System.Collections;


List<string> Materias = new List<string>();
Materias.Add("Calculo");
Materias.Add("Español");
Materias.Add("Dibujo Tecnico");
Materias.Add("Ingles");

Console.WriteLine("Total de elementos de la lista {0}", Materias.Count());
Console.WriteLine("Capacidad Total: {0}", Materias.Capacity);
Console.WriteLine("Materia[3]: {0}", Materias[4 -1]);


string ? palabra;
List<string> Dinosaurios = new List<string>();
string[] Dinos = {  "Brachioasauruss",
                    "Amargasaurus",
                    "Mamenchisaurus"};

Dinosaurios.AddRange(Dinos);
Console.WriteLine("Ingrese el nombre del dinosaurio a buscar: ");
palabra = Console.ReadLine();
Console.WriteLine(Dinosaurios.Exists(item => item.Equals(palabra)) ? "Se encontro el dinosaurio" : "No se encontro el Dinosaurio");