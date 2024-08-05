class CuentaBancaria
{
    private string _titular;
    private decimal _saldo;
    public CuentaBancaria(string titular, int saldoInicial)
    {
        _saldo = saldoInicial;
        _titular = titular;
    }
    public string Titular { get { return _titular; } set { _titular = value; } }
    public decimal Saldo { get { return _saldo; } private set { _saldo = value; } }
    public void Depositar(decimal cantidad)
    {
        if (cantidad > 0)
        {
            Saldo += cantidad;
            Console.WriteLine($"Depositaste {cantidad}. Su saldo se actualizó a: {Saldo}");
        }
        else
        {
            Console.WriteLine("Ingrese un numero mayor a 0");
        }
    }
    public void Retirar(decimal cantidad)
    {
        if (cantidad < 0)
        {
            Console.WriteLine("Ingrese un numero mayor a 0");
        }
        else if(cantidad > Saldo)
        {
            Console.WriteLine("Ingrese un numero menor o igual a su saldo actual");
        }
        else
        {
            Saldo -= cantidad;
            Console.WriteLine($"Retiraste {cantidad}. Su saldo se actualizo a: {Saldo}");
        }
    }
}
class Program
{
    static void Main()
    {
        CuentaBancaria cuenta = new CuentaBancaria("Dante", 2000);
        cuenta.Depositar(200);
        cuenta.Retirar(150);
        Console.WriteLine($"Saldo final {cuenta.Saldo}");
    }
}