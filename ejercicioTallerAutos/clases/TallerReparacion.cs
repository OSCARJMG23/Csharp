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
            return factura;
        }
        
    }
}