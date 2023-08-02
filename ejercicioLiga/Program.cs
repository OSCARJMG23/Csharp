internal class Program
{
    private static void Main(string[] args)
    {
        int opcion;
        do{
            MostrarMenu();
            opcion = PedirOpcion();

            switch(opcion){
                case 1:
                int opcionRegistro;
                    do{
                        MostrarMenuRegistro();
                        opcionRegistro = PedirOpcionRegistro();
                        switch(opcionRegistro){
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
                    }while(opcionRegistro!= 6);
                    break;
                case 2:
                int opcionConsulta;
                    do{
                        MostrarMenuConsulta();
                        opcionConsulta = PedirOpcionConsulta();
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
    static void MostrarMenu(){
        Console.WriteLine("********* Liga BetPlay *******");
        Console.WriteLine("1. Registro Plantel");
        Console.WriteLine("2. Consulta de Datos");
        Console.WriteLine("3. Salir");
    }
    static int PedirOpcion(){
        Console.Write("Elige una opción: ");
        return Convert.ToInt32(Console.ReadLine());
    }
    static void MostrarMenuRegistro(){
        Console.WriteLine("********* Registro Plantel *******");
        Console.WriteLine("1.1 - Registro de Equipo");
        Console.WriteLine("1.2 - Registro Jugador");
        Console.WriteLine("1.3 - Registro Entrenador");
        Console.WriteLine("1.4 - Registro Masajista");
        Console.WriteLine("1.5 - Venta Jugador");
        Console.WriteLine("1.6 - Regresar Menu Principal");
    }
    static int PedirOpcionRegistro(){
        Console.Write("Elige una opción: ");
        return Convert.ToInt32(Console.ReadLine());
    }
    static void MostrarMenuConsulta(){
        Console.WriteLine("********* Consulta de Datos *******");
        Console.WriteLine("2.1 - Listar Jugadores por Equipo");
        Console.WriteLine("2.2 - Buscar los Delanteros de cada Equipo");
        Console.WriteLine("2.3 - Buscar Cuerpo de Entrenadores por Equipo");
        Console.WriteLine("2.4 - Regresar Menu Principal");
    }
    static int PedirOpcionConsulta(){
        Console.Write("Elige una opción: ");
        return Convert.ToInt32(Console.ReadLine());
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