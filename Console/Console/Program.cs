public class NombreEventArgs : EventArgs
{
    public string Anterior { get; set; }
    public string Actual { get; set; }
}
class Program
{
    public delegate void actualizacionNombreCompletado(string nombre);
    static void Main(String[] args)
    {
        Persona persona = new Persona();
        persona.NombreModificado += ActualizacionNombreCompletado;
        persona.ActualizarNombre("Pablo");
    }
    static void ActualizacionNombreCompletado (object sender, NombreEventArgs e)
    {
        Console.Write($"El nombre fue modificado de {e.Anterior} a {e.Actual}");
    }
}
public class Persona
{
    private string Nombre { get; set; }
    public EventHandler<NombreEventArgs> NombreModificado;
    public void ActualizarNombre(string nombre)
    {
        string anterior = this.Nombre;
        this.Nombre = nombre;
        if (this.NombreModificado != null)
        {
            this.NombreModificado(this, new NombreEventArgs { Actual = nombre, Anterior = anterior }); ;
        }
    }
}
public class Logger
{
    public void ImprimirEnPantalla()
    {

    }
}
