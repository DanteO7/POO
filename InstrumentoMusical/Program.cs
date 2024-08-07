class InstrumentoMusical
{
    public string Nombre {  get; set; }
    public string Tipo { get; set; }
    public InstrumentoMusical(string nombre, string tipo)
    {
        Nombre = nombre;
        Tipo = tipo;
    }
    protected void MostrarDetallesInstrumento()
    {
        Console.WriteLine($"\nNombre: {Nombre}, Tipo: {Tipo}");
    }
}
class InstrumentoMusicalCuerda : InstrumentoMusical
{
    public int NumeroDeCuerdas {  get; set; }
    public InstrumentoMusicalCuerda (string nombre, string tipo, int numeroDeCuerdas) : base (nombre, tipo)
    {
        NumeroDeCuerdas = numeroDeCuerdas;
    }
    public void MostrarDetallesInstrumentoCuerda()
    {
        MostrarDetallesInstrumento();
        Console.WriteLine($"Numero de cuerdas: {NumeroDeCuerdas}");
    }
}
class InstrumentoMusicalViento : InstrumentoMusical
{
    public string Material {  get; set; }
    public InstrumentoMusicalViento(string nombre, string tipo, string material) : base(nombre, tipo)
    {
        Material = material;
    }
    public void MostrarDetallesInstrumentoViento()
    {
        MostrarDetallesInstrumento();
        Console.WriteLine($"Material: {Material}");
    }
}
class InstrumentoMusicalPercusion : InstrumentoMusical
{
    public string MetodoDeToque { get; set; }
    public InstrumentoMusicalPercusion(string nombre, string tipo, string metodoDeToque) : base(nombre, tipo)
    {
        MetodoDeToque = metodoDeToque;
    }
    public void MostrarDetallesInstrumentoPercusion()
    {
        MostrarDetallesInstrumento();
        Console.WriteLine($"Metodo de toque: {MetodoDeToque}");
    }
}
class Guitarra : InstrumentoMusicalCuerda
{
    public Guitarra(string nombre, string tipo, int numeroDeCuerdas) : base(nombre, tipo, numeroDeCuerdas) { }
    public void MostrarDetallesGuitarra()
    {
        MostrarDetallesInstrumentoCuerda();
    }
}
class Piano : InstrumentoMusicalCuerda
{
    public int NumeroDeTeclas {  get; set; }
    public Piano(string nombre, string tipo, int numeroDeCuerdas, int numeroDeTeclas) : base(nombre, tipo, numeroDeCuerdas)
    {
        NumeroDeTeclas = numeroDeTeclas;
    }
    public void MostrarDetallesPiano()
    {
        MostrarDetallesInstrumentoCuerda();
        Console.WriteLine($"Numero de teclas: {NumeroDeTeclas}");
    }
}
class Flauta : InstrumentoMusicalViento
{
    public Flauta(string nombre, string tipo, string material) : base(nombre, tipo, material) { }
    public void MostrarDetallesFlauta()
    {
        MostrarDetallesInstrumentoViento();
    }
}
class Bateria : InstrumentoMusicalPercusion
{
    public int NumeroDePlatillos {  get; set; }
    public Bateria(string nombre, string tipo, string metodoDeToque, int numeroDePlatillos) : base(nombre, tipo, metodoDeToque)
    {
        NumeroDePlatillos = numeroDePlatillos;
    }
    public void MostrarDetallesBateria()
    {
        MostrarDetallesInstrumentoPercusion();
        Console.WriteLine($"Numero de platillos: {NumeroDePlatillos}");
    }
}
class Pandereta : InstrumentoMusicalPercusion
{
    public Pandereta(string nombre, string tipo, string metodoDeToque) : base(nombre, tipo, metodoDeToque) { }
    public void MostrarDetallesPandereta()
    {
        MostrarDetallesInstrumentoPercusion();
    }
}
class Program
{
    static void Main()
    {
        Guitarra guitarra = new Guitarra("Guitarra electrica", "Cuerdas", 6);
        Piano piano = new Piano("Piano de cola", "Cuerdas", 230, 88);
        Flauta flauta = new Flauta("Flauta dulce","Viento", "Madera");
        Bateria bateria = new Bateria("Bateria acustica", "Percusion", "Con baquetas", 4);
        Pandereta pandereta = new Pandereta("Pandereta tradicional", "Percusion", "Con las manos");

        guitarra.MostrarDetallesGuitarra();
        piano.MostrarDetallesPiano();
        flauta.MostrarDetallesFlauta();
        bateria.MostrarDetallesBateria();
        pandereta.MostrarDetallesPandereta();
    }
}