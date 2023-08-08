using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ejercicioTallerAutos.clases
{
    public class OrdenServicio
    {
        public int NumeroOrden {get; set;}
        public DateTime FechaOrden {get; set;}
        public Cliente Cliente {get; set;}
        public Vehiculo Vehiculo {get; set;}
        public Empleado Empleado {get; set;}
        public string DiagnosticoCliente {get; set;}
        public List<DetalleAprobacionRepuesto> DetallesAprobacion {get; set;}
        public List<DiagnosticoExperto> DiagnosticosExpertos {get; set;}


        public OrdenServicio(Cliente cliente, Vehiculo vehiculo, Empleado empleado, string diagnosticoCliente)
        {
            this.Cliente = cliente;
            this.Vehiculo = vehiculo;
            this.Empleado = empleado;
            this.DiagnosticoCliente = diagnosticoCliente;
            this.DetallesAprobacion = new List<DetalleAprobacionRepuesto>();
            this.DiagnosticosExpertos = new List<DiagnosticoExperto>();
        }
        public void agregarDetalleAprobacion(DetalleAprobacionRepuesto detalle)
        {
            DetallesAprobacion.Add(detalle);
        }
        public void agregarDiagnosticoExperto(Empleado empleado, string diagnostico)
        {
            DiagnosticosExpertos.Add(new DiagnosticoExperto(empleado, diagnostico));
        }
        public void agregarDiagnosticoCliente(string diagnostico)
        {
            DiagnosticoCliente = diagnostico;
        }
    }
}