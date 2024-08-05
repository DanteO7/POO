public abstract class FormaGeometrica
{
    public abstract double CalcularArea();
}

public class Rectangulo : FormaGeometrica
{
    public double Largo { get; set; }
    public double Ancho { get; set; }

    public Rectangulo(double largo, double ancho)
    {
        Largo = largo;
        Ancho = ancho; 
    }

    public override double CalcularArea()
    {
         return Largo* Ancho;
    }
}

public class Circulo : FormaGeometrica
{
    public double Radio { get; set; }

    public Circulo(double radio)
    {
        Radio = radio;  
    }

    public override double CalcularArea()
    {
        return Math.PI * Radio * Radio;
    }

}

class Program
{
    static void Main()
    {
        FormaGeometrica rectangulo = new Rectangulo(2, 4);
        Console.WriteLine($"El area de un rectangulo es {rectangulo.CalcularArea()}.");
        FormaGeometrica circulo = new Circulo(2);
        Console.WriteLine($"El area de un circulo es {circulo.CalcularArea()}.");
    }
}