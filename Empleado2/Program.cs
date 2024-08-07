class Empleado
{
    private string _nombre;
    private decimal _salario;
    public string Nombre { get { return _nombre; } set { _nombre = value; } }
    protected decimal Salario { get { return _salario; } set { if (value >= 0) { _salario = value; } else { Console.WriteLine("El salario no puede ser negativo"); } } }
    public Empleado(string nombre, decimal salario)
    {
        Nombre = nombre;
        Salario = salario;
    }
    public void MostrarInformacion()
    {
        Console.WriteLine($"\nNombre: {Nombre}, Salario: {Salario}");
    }
}
class Gerente : Empleado
{
    public string Departamento { get; set; }
    public Gerente(string nombre, decimal salario, string departamento) : base(nombre, salario)
    {
        Departamento = departamento;
    }
    public void MostrarInformacionGerente()
    {
        MostrarInformacion();
        Console.WriteLine($"Departamento: {Departamento}");
    }
}
class Program
{
    static void Main()
    {
        Gerente gerente = new Gerente("Dante", 6000, "TI");
        gerente.MostrarInformacion();
        gerente.MostrarInformacionGerente();
    }
}