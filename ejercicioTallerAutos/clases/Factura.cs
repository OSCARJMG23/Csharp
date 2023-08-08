using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ejercicioTallerAutos.clases
{
    public class Factura
    {
        public int NumeroOrden {get;set;}
        public string IdCliente {get; set;}
        public double SubTotal {get; set;}
        public double Iva {get; set;}
        public double ManoObra {get; set;}
        public double TotalPagar {get; set;}

        public Factura(int numOrden, string idCliente, double subtotal, double iva, double manoObra, double totalPagar)
        {
            this.NumeroOrden = numOrden;
            this.IdCliente = idCliente;
            this.SubTotal = subtotal;
            this.Iva = iva;
            this.ManoObra = manoObra;
            this.TotalPagar = totalPagar;
        }

        public override string ToString()
        {
            return $@"
                    ---------------Factura------------------
                    numero Orden: {NumeroOrden}   numero Factura: {IdCliente}
                    Id cliente: {IdCliente}
                    ----------------Detalle Factura----------------------
                    | item | Repuesto | valor unitario | cantidad | subtotal |
                    |      |          |                |          |          |
                    |      |          |                |          |          |
                    |      |          |                |          |          |
                    |      |          |                |          |          |
                    --------------------------------------------------------------
                                                    Subtotal: {Subtotal}
                                                    Iva 19%: {IVA}
                                                    Valor mano de obra: {ManoObra}
                                                    Total Pagar: {TotalPagar}
            ";
        }
    }
}