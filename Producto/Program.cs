﻿class Producto
{
    public string Codigo { get; private set; }
    public string Nombre { get; private set; }
    public int CantidadStock { get; private set; }
    public decimal Precio { get; private set; }
    public Producto(string codigo, string nombre, int cantidadStock, decimal precio)
    {
        Codigo = codigo;
        Nombre = nombre;
        CantidadStock = cantidadStock;
        Precio = precio;
    }
    public void MostrarInformacionProducto()
    {
        Console.WriteLine($"Nombre: {Nombre}, Código: {Codigo}, Precio: {Precio:C}, Cantidad en Stock: {CantidadStock}");
    }
    public void ActualizarStockEmpresa(int cantidad)
    {
        if (CantidadStock + cantidad >=0)
        {
            CantidadStock += cantidad;
            Console.WriteLine($"Stock actualizado a: {CantidadStock}");
        }
        else
        {
            Console.WriteLine("No se puede actualizar el stock");
        }
    }
    public void ActualizarStock(int cantidad)
    {
        if (CantidadStock + cantidad >= 0 && CantidadStock + cantidad <= CantidadStock)
        {
            CantidadStock += cantidad;
            Console.WriteLine($"Stock actualizado a: {CantidadStock}");
        }
        else
        {
            Console.WriteLine("No se puede actualizar el stock");
        }
    }
}
class OrdenCompra
{
    private List<Producto> _productos;
    public OrdenCompra()
    {
        _productos = new List<Producto>();
    }
    public void AgregarProducto(Producto producto, int cantidadAgregar)
    {
        if (cantidadAgregar <=  producto.CantidadStock)
        {
            _productos.Add(producto);
            Console.WriteLine($"Usted ha agregado: {producto.Nombre} al carrito");
        }
        else
        {
            Console.WriteLine($"No se pudo agregar '{producto.Nombre}' al carrito");
        }
    }
    public void SacarProducto(Producto producto, int cantidadSacar)
    {
        if (cantidadSacar <= _productos.Count)
        {
            _productos.Remove(producto);
            Console.WriteLine($"Usted ha sacado: {producto.Nombre} del carrito");
        }
        else
        {
            Console.WriteLine($"No se pudo sacar '{producto.Nombre}' del carrito");
        }
    }
    public decimal CalcularTotal()
    {
        decimal total = 0;
        foreach (var producto in _productos)
        {
            total += producto.Precio;
        }
        return total;
    }
    public void MostrarDetalleOrden()
    {
        Console.WriteLine("Detalle de la orden de compra: ");
        Console.WriteLine($"Total de la orden: {CalcularTotal():C}");
        foreach (var producto in _productos)
        {
            Console.WriteLine($"Producto: {producto.Nombre}, Precio: {producto.Precio:C}");
        }

    }
    public bool OrdenCompraVacia()
    {
        if (_productos.Count > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
class Program
{
    static void Main()
    {
        Producto productito = new Producto("COD_1", "Coca-Cola", 10, 2500);
        OrdenCompra ordenDeComprita = new OrdenCompra();
        bool bandera = true;
        bool banderaSalir = true;
        Console.WriteLine("\nSeleccione la accion que desea realizar");
        Console.WriteLine("1 - Ver Producto a la venta");
        Console.WriteLine("2 - Agregar producto al carrito");
        Console.WriteLine("3 - Sacar producto al carrito");
        Console.WriteLine("4 - Mostrar carrito");
        Console.WriteLine("5 - Comprar");
        Console.WriteLine("6 - Salir del Programa\n");
        int accionUsuario;
        int.TryParse(Console.ReadLine(), out accionUsuario);
        while (bandera)
        {
            switch (accionUsuario)
            {
                case 1:
                    productito.MostrarInformacionProducto();
                    break;
                case 2:
                    Console.Write("Seleccione la cantidad que desea comprar: ");
                    int cantidadAgregar;
                    int.TryParse(Console.ReadLine(), out cantidadAgregar);
                    productito.ActualizarStock(-cantidadAgregar);
                    for (int i=0; i < cantidadAgregar; i++)
                    {
                        ordenDeComprita.AgregarProducto(productito, -cantidadAgregar);
                    }
                    break;
                case 3:
                    if (ordenDeComprita.OrdenCompraVacia())
                    {
                        Console.Write("Seleccione la cantidad que desea sacar del carrito: ");
                        int cantidadSacar;
                        int.TryParse(Console.ReadLine(), out cantidadSacar);
                        productito.ActualizarStock(cantidadSacar);
                        for (int i = 0; i < cantidadSacar; i++)
                        {
                            ordenDeComprita.SacarProducto(productito, cantidadSacar);
                        }
                    }
                    else
                    {
                        Console.WriteLine("El carrito esta vacío");
                    }
                    break;
                case 4:
                    if (ordenDeComprita.OrdenCompraVacia())
                    {
                        ordenDeComprita.MostrarDetalleOrden();
                    }
                    else
                    {
                        Console.WriteLine("El carrito esta vacío");
                    }
                    break;
                case 5:
                    if (ordenDeComprita.OrdenCompraVacia())
                    {
                        Console.WriteLine("Usted va a comprar: ");
                    ordenDeComprita.MostrarDetalleOrden();
                    Console.WriteLine("\nQuiere confirmar la compra?");
                    Console.WriteLine("1 - Confirmar compra");
                    Console.WriteLine("2 - Volver atrás");
                    int confirmarCompra;
                    int.TryParse(Console.ReadLine(), out confirmarCompra);
                    bool banderaConfirmacion = true;
                    while (banderaConfirmacion)
                    {
                        switch (confirmarCompra)
                        {
                            case 1:
                                Console.WriteLine("Felicidades, Usted ha comprado: ");
                                ordenDeComprita.MostrarDetalleOrden();
                                banderaConfirmacion = false;
                                banderaSalir = false;
                                bandera = false;
                                break;
                            case 2:
                                banderaConfirmacion = false;
                                break;
                            default:
                                Console.WriteLine("ERROR. Ingrese una accion válida\n");
                                break;
                        }
                        if (banderaConfirmacion)
                        {
                            Console.WriteLine("\nQuiere confirmar la compra?");
                            Console.WriteLine("1 - Confirmar compra");
                            Console.WriteLine("2 - Volver atrás");
                            int.TryParse(Console.ReadLine(), out confirmarCompra);
                        }
                    }
                    }
                    else
                    {
                        Console.WriteLine("El carrito esta vacío");
                    }
                    
                    break;
                case 6:
                    bandera = false;
                    banderaSalir = false;
                    break;
                default:
                    Console.WriteLine("ERROR. Ingrese una accion válida\n");
                    break;
            }
            if (banderaSalir)
            {
                Console.WriteLine("\nSeleccione la accion que desea realizar");
                Console.WriteLine("1 - Ver Producto a la venta");
                Console.WriteLine("2 - Agregar producto al carrito");
                Console.WriteLine("3 - Sacar producto al carrito");
                Console.WriteLine("4 - Mostrar carrito");
                Console.WriteLine("5 - Comprar");
                Console.WriteLine("6 - Salir del Programa\n");
                int.TryParse(Console.ReadLine(), out accionUsuario);
            }
            else
            {
                Console.WriteLine("\nSaliendo del Programa....");
            }
            
        }
    }
}
