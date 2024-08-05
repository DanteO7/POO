class Estudiante
{
    private string _nombre;
    private int _legajo;
    private double _promedio;

    public Estudiante(string nombre, int legajo, double promedioInicial = 0)
    {
        _nombre = nombre;
        _legajo = legajo;
        _promedio = promedioInicial;
    }

    public string Nombre { get { return _nombre; } set { _nombre = value; } }
    public int Legajo { get { return _legajo; } set { _legajo = value; } }
    public double Promedio { get { return _promedio; } private set { _promedio = value; } }
    
    int contador = 0;
    public void ActualizacionPromedio(double nota)
    {
        
        if (nota >= 0 && nota <= 10)
        {
            contador++;
            Promedio += nota;
            Console.WriteLine($"Alumno: {Nombre}; Nro de legajo: {Legajo}; Promedio: {Promedio/contador}.");
        }
        else
        {
            Console.WriteLine("Ingrese una nota entre el 0 y el 10.");
        }
    }
}
class Program
{
    static void Main()
    {
        Estudiante estudiante = new Estudiante("Dante", 1);
        estudiante.ActualizacionPromedio(12);
        estudiante.ActualizacionPromedio(6);
        estudiante.ActualizacionPromedio(7);
        estudiante.ActualizacionPromedio(8);
    }
}