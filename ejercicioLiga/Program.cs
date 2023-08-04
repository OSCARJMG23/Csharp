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
                                Liga ligaBusacarJugador = new Liga();
                                Liga opcionLigaJugador= ligaBusacarJugador.buscarLiga(Ligas);
                                Equipo equipoBuscarJugador = new Equipo();
                                equipoBuscarJugador = equipoBuscarJugador.consultarEquipo(opcionLigaJugador.EquiposLiga);
                                Jugador jugador = new Jugador();
                                jugador = jugador.agregarJugador();
                                equipoBuscarJugador.Jugadores.Add(jugador);

                                break;
                            case 3:
                                Liga ligaBuscarEntrenador = new Liga();
                                Liga opcionLigaEntrenador = ligaBuscarEntrenador.buscarLiga(Ligas);
                                Equipo equipoBuscarEntrenador = new Equipo();
                                equipoBuscarEntrenador = equipoBuscarEntrenador.consultarEquipo(opcionLigaEntrenador.EquiposLiga);
                                Entrenador entrenador = new Entrenador();
                                entrenador = entrenador.agregarEntrenador();
                                equipoBuscarEntrenador.Entrenadores.Add(entrenador);

                                break;
                            case 4:
                                Liga ligaBuscarMasajista = new Liga();
                                Liga opcionLigaMasajista = ligaBuscarMasajista.buscarLiga(Ligas);
                                Equipo equipoBuscarMasajista = new Equipo();
                                equipoBuscarMasajista = equipoBuscarMasajista.consultarEquipo(opcionLigaMasajista.EquiposLiga);
                                Masajista masajista = new Masajista();
                                masajista = masajista.agregarMasajista();
                                equipoBuscarMasajista.Masajistas.Add(masajista);

                                break;
                            case 5:
                                Console.WriteLine("Transferencia de Jugadores");
                                Liga buscarLigaSalida = new Liga();
                                Liga opcionLigaSalida = buscarLigaSalida.buscarLiga(Ligas);
                                Equipo equipoBuscarSalida = new Equipo();
                                equipoBuscarSalida = equipoBuscarSalida.consultarEquipo(opcionLigaSalida.EquiposLiga);
                                Jugador judarTransferido = new Jugador();
                                jugadorTransferido = judarTransferido.buscarJugador.(equipoBuscarSalida.Jugadores);
                                

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
                                Console.WriteLine("Listar Jugadores por Equipo");
                                Liga ligaBuscarJugadores = new Liga();
                                Liga opcionLigaJugadores = ligaBuscarJugadores.buscarLiga(Ligas);
                                Equipo equipoBuscarJugadores = new Equipo();
                                equipoBuscarJugadores = equipoBuscarJugadores.consultarEquipo(opcionLigaJugadores.EquiposLiga);
                                equipoBuscarJugadores.listarJugadores(equipoBuscarJugadores.Jugadores);
                                break;
                            case 3:
                                Console.WriteLine("Delanteros por Equipo");
                                Liga ligaBuscarDelantero = new Liga();
                                Liga opcionLigaDelantero = ligaBuscarDelantero.buscarLiga(Ligas);
                                Equipo equipoBuscarDelantero = new Equipo();
                                equipoBuscarDelantero = equipoBuscarDelantero.consultarEquipo(opcionLigaDelantero.EquiposLiga);
                                equipoBuscarDelantero.listarDelanteros(equipoBuscarDelantero.Jugadores);
                                break;
                            case 4:
                                Console.WriteLine("Consultar entrenadores por Equipo");
                                Liga ligaBuscarEntrenador = new Liga();
                                Liga opcionLigaEntrenador = ligaBuscarEntrenador.buscarLiga(Ligas);
                                Equipo equipoBuscarEntrenador = new Equipo();
                                equipoBuscarEntrenador = equipoBuscarEntrenador.consultarEquipo(opcionLigaEntrenador.EquiposLiga);
                                equipoBuscarEntrenador.listarEntrenadores(equipoBuscarEntrenador.Entrenadores);
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