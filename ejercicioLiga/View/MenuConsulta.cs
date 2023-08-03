using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ejercicioLiga.View
{
    public class MenuConsulta
    {
        public MenuConsulta(){  }

        public int menuConsulta(){
            Console.WriteLine("********* Consulta de Datos *******");
            Console.WriteLine("2.1 - Consultar Equipo");
            Console.WriteLine("2.2 - Listar Jugadores por Equipo");
            Console.WriteLine("2.3 - Buscar los Delanteros de cada Equipo");
            Console.WriteLine("2.4 - Buscar Cuerpo de Entrenadores por Equipo");
            Console.WriteLine("2.5 - Regresar Menu Principal");
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}