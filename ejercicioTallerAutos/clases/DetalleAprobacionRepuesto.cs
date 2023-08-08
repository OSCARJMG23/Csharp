using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ejercicioTallerAutos.clases
{
    public class DetalleAprobacionRepuesto
    {
        public string Item {get; set;}
        public string Repuesto {get; set;}
        public double ValorUnitario {get; set;}
        public int Cantidad {get; set;}
        public double ValorTotal {get {return ValorUnitario * Cantidad; }}
        public char Estado {get; set;}

        public const char EstadoAprobado = 'A';
        public const char EstadoReprobado = 'R';


        public DetalleAprobacionRepuesto(string repuesto, double valorUnitario, int cantidad, char estado)
        {
            this.Repuesto = repuesto;
            this.ValorUnitario = valorUnitario;
            this.Cantidad = cantidad;
            this.Estado = estado;
        }
    }
}