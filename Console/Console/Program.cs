using Logica;
class Program
{
    public delegate void actualizacionNombreCompletado(string nombre);
    static void Main(String[] args)
    {
        Persona persona = new Persona();
        persona.NombreModificado += Logger.ImprimirEnPantalla;
        persona.ActualizarNombre("Pablo");

        Console.Read();
    }
}
