using ejercicioLiga.View;

internal class Program
{
    private static void Main(string[] args)
    {
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
                                RegistrarEquipo();
                                break;
                            case 2:
                                RegistrarJugador();
                                break;
                            case 3:
                                RegistrarEntrenador();
                                break;
                            case 4:
                                RegistrarMadajista();
                                break;
                            case 5:
                                VenderJugador();
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
                                ListarJugadorXequipo();
                                break;
                            case 2:
                                BuscarDelanterosXequipo();
                                break;
                            case 3:
                                BuscarEntrenadorXequipo();
                                break;
                            case 4:
                                Console.WriteLine("Volviendo al Menu Principal");
                                break;
                            default:
                                Console.WriteLine("Opcion no valida");
                                break;
                        }
                        break;
                    }while(opcionConsulta!= 4);
                    break;
                case 3:
                    Console.WriteLine("Hasta Luego");
                    break;
                default:
                    Console.WriteLine("Opcion no valida");
                break;
            }
        }while(opcion !=3);
        
    }

    static void RegistrarEquipo(){
            Console.WriteLine("Registro de Equipo");
        }
    static void RegistrarJugador(){
            Console.WriteLine("Registro de Jugador");
        }
    static void RegistrarEntrenador(){
            Console.WriteLine("Registro de Entrenador");
        }
    static void RegistrarMadajista(){
            Console.WriteLine("Registro de Madajista");
        }
    static void VenderJugador(){
            Console.WriteLine("Venta de Jugador");
        }

    static void ListarJugadorXequipo(){
        Console.WriteLine("Listado de jugadores x equipo");
    }
    static void BuscarDelanterosXequipo(){
        Console.WriteLine("Buscar delanteros x equipo");
    }
    static void BuscarEntrenadorXequipo(){
        Console.WriteLine("Buscar entrenadores x equipo");
    }
    
}