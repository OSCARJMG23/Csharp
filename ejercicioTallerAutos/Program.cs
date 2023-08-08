using ejercicioTallerAutos.view;
using ejercicioTallerAutos.clases;
/* using ejercicioTallerAutos.clases; */
internal class Program
{
    private static void Main(string[] args)
    {
        int opcion;
        MenuRegistro menuRegistro = new MenuRegistro();
        TallerReparacion taller = new TallerReparacion();
        do{
            opcion = menuRegistro.MostrarMenu();
            switch(opcion){
                case 1:
                    Console.WriteLine("Registro de Cliente");
                    Cliente nuevoCliente = new Cliente();
                    nuevoCliente = nuevoCliente.agregarCliente();
                    taller.registrarCliente(nuevoCliente);
                    break;
                case 2:
                    Console.WriteLine("Registro del vehiculo del cliente");
                    taller.listarClientes();
                    Console.Write("Ingrese el numero de documento del cliente para agregar el vehiculo: ");
                    double numeroDocumentoCliente = Convert.ToDouble(Console.ReadLine());
                    Cliente clienteEncontrado = taller.Clientes.Find(cliente => cliente.Cc == numeroDocumentoCliente);
                    if(clienteEncontrado != null)
                    {
                        taller.registrarVehiculoCliente(clienteEncontrado);
                    }
                    else
                    {
                        Console.WriteLine("Cliente no encontrado");
                    }
                    break;
                case 3:
                    Console.WriteLine("Registro de Empleado");
                    Empleado nuevoEmpleado = new Empleado();
                    nuevoEmpleado = nuevoEmpleado.agregarEmpleado();
                    taller.registrarEmpleado(nuevoEmpleado);
                    break;
                case 4:
                    taller.listarClientes();
                    break;
                case 5:
                    taller.listarEmpleados();
                    break;
                case 6:
                    Console.WriteLine("Creando Servicio/Orden");
                    taller.listarClientes();
                    Console.Write("Ingrese el número de documento del cliente: ");
                    double numeroDocumentoClienteOrden = Convert.ToDouble(Console.ReadLine());
                    Cliente clienteOrden = taller.Clientes.Find(cliente => cliente.Cc == numeroDocumentoClienteOrden);

                    if (clienteOrden != null)
                    {
                        Console.WriteLine("Vehículos disponibles:");
                        foreach (var vehiculo in clienteOrden.Vehiculos)
                        {
                            Console.WriteLine($"Placa: {vehiculo.Placa}, Marca: {vehiculo.Marca}, Modelo: {vehiculo.Modelo}");
                        }
                        Console.Write("Ingrese la placa del vehículo: ");
                        string placaVehiculo = Console.ReadLine();
                        Vehiculo vehiculoOrden = clienteOrden.Vehiculos.Find(vehiculo => vehiculo.Placa == placaVehiculo);

                        if (vehiculoOrden != null)
                        {
                            Console.WriteLine("Empleados disponibles:");
                            taller.listarEmpleados();
                            Console.Write("Ingrese el número de documento del empleado a cargo: ");
                            double numeroDocumentoEmpleadoOrden = Convert.ToDouble(Console.ReadLine());
                            Empleado empleadoOrden = taller.Empleados.Find(empleado => empleado.Cc == numeroDocumentoEmpleadoOrden);

                            if (empleadoOrden != null)
                            {
                                Console.Write("Ingrese el diagnóstico del cliente: ");
                                string diagnosticoCliente = Console.ReadLine();

                                OrdenServicio nuevaOrden = new OrdenServicio(clienteOrden, vehiculoOrden, empleadoOrden, diagnosticoCliente);

                                Console.Write("¿Desea agregar un diagnóstico experto? (S/N): ");
                                char opcionDiagnosticoExperto = Console.ReadLine().ToUpper()[0];

                                while (opcionDiagnosticoExperto == 'S')
                                {
                                    Console.WriteLine("Empleados disponibles:");
                                    taller.listarEmpleados();
                                    Console.Write("Ingrese el número de documento del empleado experto: ");
                                    double numeroDocumentoEmpleadoExperto = Convert.ToDouble(Console.ReadLine());
                                    Empleado empleadoExperto = taller.Empleados.Find(empleado => empleado.Cc == numeroDocumentoEmpleadoExperto);

                                    if (empleadoExperto != null)
                                    {
                                        Console.Write("Ingrese el diagnóstico experto: ");
                                        string diagnosticoExperto = Console.ReadLine();
                                        nuevaOrden.agregarDiagnosticoExperto(empleadoExperto, diagnosticoExperto);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Empleado experto no encontrado.");
                                    }

                                    Console.Write("¿Desea agregar otro diagnóstico experto? (S/N): ");
                                    opcionDiagnosticoExperto = Console.ReadLine().ToUpper()[0];
                                }
                                    Console.Write("¿Desea agregar detalles de aprobación de repuestos? (S/N): ");
                                    char opcionDetalles = Console.ReadLine().ToUpper()[0];

                                    while (opcionDetalles == 'S')
                                    {
                                        Console.Write("Ingrese el nombre del repuesto: ");
                                        string nombreRepuesto = Console.ReadLine();
                                        Console.Write("Ingrese el valor unitario del repuesto: ");
                                        double valorUnitarioRepuesto = Convert.ToDouble(Console.ReadLine());
                                        Console.Write("Ingrese la cantidad de repuestos: ");
                                        int cantidadRepuestos = Convert.ToInt32(Console.ReadLine());
                                        Console.Write("Ingrese el estado de aprobación (A/R): ");
                                        char estadoRepuesto = Console.ReadLine().ToUpper()[0];

                                        DetalleAprobacionRepuesto detalleRepuesto = new DetalleAprobacionRepuesto(nombreRepuesto, valorUnitarioRepuesto, cantidadRepuestos, estadoRepuesto);
                                        nuevaOrden.agregarDetalleAprobacion(detalleRepuesto);

                                        Console.Write("¿Desea agregar otro detalle de aprobación? (S/N): ");
                                        opcionDetalles = Console.ReadLine().ToUpper()[0];
                                    }

                                taller.generarOrdenServicio(nuevaOrden);
                                Console.WriteLine("Orden de servicio creada exitosamente.");
                            }
                            else
                            {
                                Console.WriteLine("Empleado no encontrado.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Vehículo no encontrado.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Cliente no encontrado.");
                    }
                    break;
                case 7:
                    break;
                case 8:
                    Console.WriteLine("Hasta Luego");
                    break;
                default:
                Console.WriteLine("Ingrese una opción valida");
                    break;
            }
        }while(opcion !=8);
    }
}