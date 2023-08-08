using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ejercicioTallerAutos.clases
{
    public class DiagnosticoExperto
    {
        public Empleado Empleado {get; set;}
        public string Diagnostico {get; set;}

        public DiagnosticoExperto(Empleado empleado, string diagnostico)
        {
            this.Empleado = empleado;
            this.Diagnostico = diagnostico;
        }
    }
}