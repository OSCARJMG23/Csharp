using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ejercicioTallerAutos.clases
{
    public class Factura
    {
        public int NumeroOrden {get;set;}
        public double IdCliente {get; set;}
        public double SubTotal {get; set;}
        public double Iva {get; set;}
        public double ManoObra {get; set;}
        public double TotalPagar {get; set;}
        public List<DetalleAprobacionRepuesto> DetallesAprobados {get; set;}

        public Factura(int numOrden, double idCliente, double subtotal, double iva, double manoObra, double totalPagar, List<DetalleAprobacionRepuesto> detallesAprobados)
        {
            this.NumeroOrden = numOrden;
            this.IdCliente = idCliente;
            this.SubTotal = subtotal;
            this.Iva = iva;
            this.ManoObra = manoObra;
            this.TotalPagar = totalPagar;
            this.DetallesAprobados = detallesAprobados;
        }

        public override string ToString()
        {
            return $@"
                            ---------------Factura------------------
                    numero Orden: {this.NumeroOrden}   numero Factura: {this.IdCliente}
                    Id cliente: {this.IdCliente}
                    ---------------------Detalle Factura----------------------
                    | item | Repuesto | valor unitario | cantidad | subtotal |
                    |      |          |                |          |          |
                    |      |          |                |          |          |
                    |      |          |                |          |          |
                    |      |          |                |          |          |
                    ----------------------------------------------------------
                                                    Subtotal: {this.SubTotal}
                                                    Iva 19%: {this.Iva}
                                                    Valor mano de obra: {this.ManoObra}
                                                    Total Pagar: {this.TotalPagar}
            ";
        }
    }
}