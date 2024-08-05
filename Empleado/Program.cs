public abstract class Empleado
{
    public string Nombre { get; set; }
    public double Salario { get; set; }
    public Empleado(string nombre, double salario)
    {
        Nombre = nombre;
        Salario = salario;
    }
    public abstract void SalarioTotal();
}
class EmpleadoTiempoCompleto : Empleado
{
    public EmpleadoTiempoCompleto(string nombre, double salario) : base(nombre, salario){ }
    public override void SalarioTotal()
    {
        Console.WriteLine($"El salario de {Nombre} es: {Salario}.");
    }
}

class EmpleadoMedioTiempo : Empleado
{
    public EmpleadoMedioTiempo(string nombre, double salario) : base (nombre, salario){ }
    public override void SalarioTotal()
    {
        Console.WriteLine($"El salario de {Nombre} es: {Salario*0.5}.");
    }

}
class Program
{
    static void Main()
    {
        Empleado empleado1 = new EmpleadoTiempoCompleto("Dante", 5000);
        empleado1.SalarioTotal();
        Empleado empleado2 = new EmpleadoMedioTiempo("Simon", 5000);
        empleado2.SalarioTotal();
    }
}