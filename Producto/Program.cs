class Producto
{
    private string _nombre;
    private decimal _precio;
    private int _cantidadEnStock;

    public Producto(string nombre, decimal precio, int cantidadEnStock)
    {
        _nombre = nombre;
        _precio = precio;
        _cantidadEnStock = cantidadEnStock;
    }
    public string Nombre { get { return _nombre; } set { _nombre = value; } }
    public decimal Precio { get { return _precio; } set { _precio = value; } }
    public int CantidadEnStock { get { return _cantidadEnStock; } private set { _cantidadEnStock = value; } }
    public void ActualizarStock(int cantidad)
    {
        if (cantidad + CantidadEnStock >=0)
        {
            CantidadEnStock += cantidad;
            Console.WriteLine($"Cantidad en stock actualizada: {CantidadEnStock}");
        }
        else
        {
            Console.WriteLine("Ingrese una cantidad válida");
        }
    }
}
class Program
{
    static void Main()
    {
        Producto unProducto = new Producto("laptop", 2000, 50);
        Console.WriteLine($"Nombre: {unProducto.Nombre}");
        Console.WriteLine($"Precio: {unProducto.Precio}");
        Console.WriteLine($"Stock: {unProducto.CantidadEnStock}");
        unProducto.ActualizarStock(20);
        unProducto.ActualizarStock(-70);
        unProducto.ActualizarStock(50);
        unProducto.ActualizarStock(-30);
    }
}