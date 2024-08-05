public abstract class DispositivoElectronico
{
    public string Marca { get; set; }
    public DispositivoElectronico(string marca)
    {
        Marca = marca;
    }
    public abstract void Encender();
    
}
public class Radio : DispositivoElectronico
{
    public Radio(string marca) : base(marca){ }
    public override void Encender()
    {
        Console.WriteLine($"Encendiste la radio marca {Marca}.");
    }
}
public class Television : DispositivoElectronico
{
    public Television(string marca) : base(marca) { }
    public override void Encender()
    {
        Console.WriteLine($"Encendiste la television marca {Marca}.");
    }
}

class Program
{
    static void Main()
    {
        DispositivoElectronico radio = new Radio("Samsung");
        radio.Encender();
        DispositivoElectronico television = new Television("Sony");
        television.Encender();
    }
}