using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ejercicioTallerAutos.clases
{
    public class TallerReparacion
    {
        public List<Cliente> Clientes {get; set;}
        public List<Empleado> Empleados {get; set;}
        public List<OrdenServicio> Ordenes {get; set;}

        public TallerReparacion()
        {
            this.Clientes = new List<Cliente>();
            this.Empleados = new List<Empleado>();
            this.Ordenes = new List<OrdenServicio>();
        }
        
        

        public TallerReparacion registrarCliente(Cliente cliente){
            Clientes.Add(cliente);
            
            return this;
        }
        public TallerReparacion registrarEmpleado(Empleado empleado){
            Empleados.Add(empleado);
            
            return this;
        }
        public void listarClientes()
        {
            Console.WriteLine("Lista de Clientes:");
            foreach (var cliente in Clientes)
            {
                Console.WriteLine($"Nombre: {cliente.Nombre} {cliente.Apellido}");
                Console.WriteLine($"Documento: {cliente.Cc}");
                Console.WriteLine($"Número de móvil: {cliente.NumeroMovil}");
                Console.WriteLine($"Email: {cliente.Email}");
                Console.WriteLine($"Fecha de registro: {cliente.FechaRegistro}");
                Console.WriteLine("Vehículos:");
                if (cliente.Vehiculos == null)
                {
                    Console.WriteLine("Aun no hay vehículos registrados.");
                }
                else
                {
                    
                    Console.WriteLine("Vehículos:");
                    foreach (var vehiculo in cliente.Vehiculos)
                    {
                        Console.WriteLine($"- Marca: {vehiculo.Marca}, Modelo: {vehiculo.Modelo}, Placa: {vehiculo.Placa}");
                    }
                }
                    Console.WriteLine("----------");
                
            }
        }

        public void listarEmpleados()
        {
            Console.WriteLine("Lista de Empleados:");
            foreach (var empleado in Empleados)
            {
                Console.WriteLine($"Nombre: {empleado.Nombre} {empleado.Apellido}");
                Console.WriteLine($"Documento: {empleado.Cc}");
                Console.WriteLine($"Número de móvil: {empleado.NumeroMovil}");
                Console.WriteLine("Especialidades:");
                foreach (var especialidad in empleado.Especialidades)
                {
                    Console.WriteLine($"- {especialidad}");
                }
                Console.WriteLine("----------");
            }
        }

        public void registrarVehiculoCliente(Cliente cliente)
        {
            Console.WriteLine("Ingrese los detalles del vehiculo:");
            Vehiculo nuevoVehiculo = new Vehiculo();
            nuevoVehiculo.agregarVehiculo();
            cliente.AgregarVehiculo(nuevoVehiculo);
            Console.WriteLine("Vehículo agregado exitosamente al cliente.");
        }
        public void generarOrdenServicio(OrdenServicio orden)
        {
            orden.NumeroOrden = Ordenes.Count + 1;
            orden.FechaOrden = DateTime.Now;
            Ordenes.Add(orden);
        }
        public Factura facturaOrden(OrdenServicio orden)
        {
            double subtotalRepuestos = 0;
            List<DetalleAprobacionRepuesto> DetallesAprobados = new List<DetalleAprobacionRepuesto>();
            foreach(var detalle in orden.DetallesAprobacion)
            {
                if(detalle.Estado == DetalleAprobacionRepuesto.EstadoAprobado)
                {
                    subtotalRepuestos += detalle.ValorTotal;
                    DetallesAprobados.Add(detalle);
                }
            }
            double manoObra = subtotalRepuestos * 0.10;
            double subtotal = subtotalRepuestos + manoObra;
            double iva = subtotal * 0.19;
            double totalPagar = subtotal + iva;

            Factura factura = new Factura(orden.NumeroOrden, orden.Cliente.Cc, subtotal, iva, manoObra, totalPagar,DetallesAprobados);
                Console.WriteLine("--------------------------------------------------------------");
                Console.WriteLine($"Numero Orden: {factura.NumeroOrden}");
                Console.WriteLine($"Id Cliente: {factura.IdCliente}");
                Console.WriteLine("--------------------------------------------------------------");
                Console.WriteLine("| item | Repuesto | valor unitario | cantidad | valor Total | Estado |");
                Console.WriteLine("|------|----------|----------------|----------|-------------|--------|");
                    for (int i = 0; i < factura.DetallesAprobados.Count; i++)
                    {
                        DetalleAprobacionRepuesto detalle = factura.DetallesAprobados[i];
                        string estado = detalle.Estado == DetalleAprobacionRepuesto.EstadoAprobado ? "   A    " : "   R    ";

                        Console.WriteLine($"|  {i + 1,-6} |  {detalle.Repuesto,-10} |  {detalle.ValorUnitario,-15:C} |  {detalle.Cantidad,-9} |  {detalle.ValorTotal,-12:C} |  {estado} |");
                    }
                        Console.WriteLine("|-----------------------|----------------|----------|-------------|--------|");
                        Console.WriteLine($"|                       |                |          | Subtotal    | {subtotal,-7:C} |");
                        Console.WriteLine($"|                       |                |          | Iva 19%     | {iva,-7:C} |");
                        Console.WriteLine($"|                       |                |          | Mano de Obra| {manoObra,-7:C} |");
                        Console.WriteLine("|-----------------------|----------------|----------|-------------|--------|");
                        Console.WriteLine($"|                       |                |          | Total       | {totalPagar,-7:C} |");
                        Console.WriteLine("--------------------------------------------------------------");
            return factura;
        }
        public void listarOrdenes()
        {
            Console.WriteLine("Lista de Órdenes de Servicio:");
            foreach (var orden in Ordenes)
            {
                Console.WriteLine("------- Datos de la orden --------");
                Console.WriteLine($"Numero orden: {orden.NumeroOrden}   Fecha orden: {orden.FechaOrden}");
                Console.WriteLine($"Id cliente: {orden.Cliente.Cc}   Nombre cliente: {orden.Cliente.Nombre} {orden.Cliente.Apellido}");
                Console.WriteLine("-------------- Datos vehiculo  ---------------");
                Console.WriteLine($"Numero placa: {orden.Vehiculo.Placa}   Km: {orden.Vehiculo.Kilometraje}");
                Console.WriteLine("-------------- Diagnostico Cliente --------------");
                Console.WriteLine(orden.DiagnosticoCliente);
                Console.WriteLine("-------------- Personal a cargo ------------------");
                foreach (var empleado in orden.DiagnosticosExpertos.Select(diagnostico => diagnostico.Empleado))
                {
                    Console.WriteLine($"Numero Cc: {empleado.Cc}   Nombre: {empleado.Nombre} {empleado.Apellido}");
                    Console.WriteLine("Especialidad:");
                    foreach (var especialidad in empleado.Especialidades)
                    {
                        Console.WriteLine($"   - {especialidad}");
                    }
                }
                Console.WriteLine("-------------- Diagnostico Experto --------------");
                foreach (var diagnostico in orden.DiagnosticosExpertos)
                {
                    Console.WriteLine($"Numero Cc: {diagnostico.Empleado.Cc}   Nombre: {diagnostico.Empleado.Nombre} {diagnostico.Empleado.Apellido}");
                    Console.WriteLine($"Diagnostico: {diagnostico.Diagnostico}");
                }
                Console.WriteLine("-------------------------------------------------------");
            }
        }
        public void agregarMecanicoAorden(int numeroOrden)
        {
            OrdenServicio orden = Ordenes.Find(ord => ord.NumeroOrden == numeroOrden);
            if(orden != null)
            {
                Console.WriteLine("Empleados Disponibles");
                listarEmpleados();
                Console.Write("Ingrese el numero de documento del mecanico a asignar: ");
                double numeroDocumentoEmpleado = Convert.ToDouble(Console.ReadLine());
                Empleado empleado = Empleados.Find(empl => empl.Cc == numeroDocumentoEmpleado);
                if(empleado != null)
                {
                    orden.Empleado = empleado;
                    Console.WriteLine("Empleado agregado exitosamente");
                }
                else
                {
                    Console.WriteLine("No se encontró el empleado");
                }
            }
            else
            {
                Console.WriteLine("No se encontró la orden");
            }
        }
        public void listarDetallesAprobacion(int numOrden){
            OrdenServicio orden = Ordenes.Find(ord => ord.NumeroOrden == numOrden);
            if(orden != null)
            {
                Console.WriteLine($"Numero orden: {orden.NumeroOrden}");
                Console.WriteLine($"Fecha: {orden.FechaOrden}");
                Console.WriteLine($"idEmpleado: {orden.Empleado.Cc}");
                Console.WriteLine("---------------------Detalle de aprobacion-----------------");
                Console.WriteLine("|  item  |  Repuesto  |  valor unitario  |  cantidad  |  valor Total  |  Estado  |");
                Console.WriteLine("|--------------------------------------------------------|");

                for(int i = 0; i < orden.DetallesAprobacion.Count; i++)
                {
                    DetalleAprobacionRepuesto detalle = orden.DetallesAprobacion[i];
                    string estado = detalle.Estado == DetalleAprobacionRepuesto.EstadoAprobado ? "   A    " : "   R    ";
                    Console.WriteLine($"|  {i + 1,-6} |  {detalle.Repuesto,-10} |  {detalle.ValorUnitario,-15:C} |  {detalle.Cantidad,-9} |  {detalle.ValorTotal,-12:C} |  {estado} |");
                }
                Console.WriteLine("----------------------------------------------------------");
            }
        }
        
    }
}