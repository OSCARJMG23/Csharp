string ? palabra;
List<string> Dinosaurios = new List<string>();
List<string> Encontrados = new List<string>();
string[] Dinos = {  "Brachioasauruss",
                    "Amargasaurus",
                    "Mamenchisaurus"};

Dinosaurios.AddRange(Dinos);
Console.WriteLine("Ingrese la letra que desea buscar en los dinosaurios: ");
palabra = Console.ReadLine();
Encontrados = Dinosaurios.FindAll(n=> n.Contains(palabra ?? String.Empty));
foreach (String n in Encontrados){
    Console.WriteLine(n);
}