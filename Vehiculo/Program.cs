public abstract class Vehiculo
{
    public string Marca { get; set; }
    public string Modelo { get; set; }

    public Vehiculo(string marca, string modelo)
    {
        Marca = marca;
        Modelo = modelo;
    }
    public abstract void Conducir();
}

public class Auto : Vehiculo
{
    public Auto(string marca, string modelo) : base(marca, modelo) { }
    public override void Conducir()
    {
        Console.WriteLine($"Conducis un auto {Marca} {Modelo}.");
    }
}    
public class Moto : Vehiculo
{
    public Moto(string marca, string modelo) : base(marca, modelo) { }
    public override void Conducir()
    {
        Console.WriteLine($"Conducis una moto {Marca} {Modelo}.");
    }
}
class Program
{
    static void Main()
    {
        Vehiculo auto = new Auto("Ford", "Fiesta");
        auto.Conducir();
        Vehiculo moto = new Moto("Honda", "Gold Wing");
        moto.Conducir();
    }
}