using ejercicioLiga.View;
using ejercicioLiga.Clases;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Liga> Ligas = new List<Liga>();
        int opcion;
        MainMenu menuP = new MainMenu();
        do{
            opcion = menuP.MostrarMenu();

            switch(opcion){
                case 1:
                int opcionPlantel;
                MenuPlantel menuPlantel = new MenuPlantel();
                    do{
                        opcionPlantel = menuPlantel.menuPlantel();
                        switch(opcionPlantel){
                            case 1:
                                Liga ligaBusacar = new Liga();
                                Liga opcionLiga= ligaBusacar.buscarLiga(Ligas);
                                Console.WriteLine(opcionLiga.Nombre);
                                Equipo equipo = new Equipo();
                                Equipo nuevoEquipo = equipo.agregarEquipo();
                                Console.WriteLine(nuevoEquipo.Nombre);
                                opcionLiga.EquiposLiga.Add(nuevoEquipo);
                                break;
                            case 2:
                                Console.WriteLine("Volviendo al Menu Principal");
                                break;
                            case 3:
                                Console.WriteLine("Volviendo al Menu Principal");
                                break;
                            case 4:
                                Console.WriteLine("Volviendo al Menu Principal");
                                break;
                            case 5:
                                Console.WriteLine("Volviendo al Menu Principal");
                                break;
                            case 6:
                                Console.WriteLine("Volviendo al Menu Principal");
                                break;
                            default:
                                Console.WriteLine("Opcion no valida");
                                break;
                        }
                    }while(opcionPlantel!= 6);
                    break;
                case 2:
                int opcionConsulta;
                MenuConsulta menuConsulta = new MenuConsulta();
                    do{
                        opcionConsulta = menuConsulta.menuConsulta();
                        switch(opcionConsulta){
                            case 1:
                                Liga ligaBusacar = new Liga();
                                Liga opcionLiga= ligaBusacar.buscarLiga(Ligas);
                                Equipo equipoBuscar = new Equipo();
                                equipoBuscar.consultarEquipo(opcionLiga.EquiposLiga);
                                Console.WriteLine(opcionLiga.EquiposLiga.Count);
                                break;
                            case 2:
                                Console.WriteLine("Volviendo al Menu Principal");
                                break;
                            case 3:
                                Console.WriteLine("Volviendo al Menu Principal");
                                break;
                            case 4:
                                Console.WriteLine("Volviendo al Menu Principal");
                                break;
                            case 5:
                                Console.WriteLine("Volviendo al Menu Principal");
                                break;
                            default:
                                Console.WriteLine("Opcion no valida");
                                break;
                        }
                        break;
                    }while(opcionConsulta!= 5);
                    break;
                case 3:
                    Liga liga = new Liga();
                    Ligas.Add(liga.agregarLiga());
                    liga.mostrarLigas(Ligas);
                    break;
                case 4:
                    Console.WriteLine("Hasta Luego");
                    break;
                default:
                    Console.WriteLine("Opcion no valida");
                break;
            }
        }while(opcion !=4);
        
    }

}