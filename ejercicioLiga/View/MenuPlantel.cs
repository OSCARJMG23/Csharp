using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ejercicioLiga.View
{
    public class MenuPlantel
    {
        public MenuPlantel(){  }

        public int menuPlantel(){
            Console.WriteLine("********* Registro Plantel *******");
            Console.WriteLine("1.1 - Registro de Equipo");
            Console.WriteLine("1.2 - Registro Jugador");
            Console.WriteLine("1.3 - Registro Entrenador");
            Console.WriteLine("1.4 - Registro Masajista");
            Console.WriteLine("1.5 - Venta Jugador");
            Console.WriteLine("1.6 - Regresar Menu Principal");
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}