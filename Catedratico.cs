namespace Laboratorio10
{
    public class Catedratico : Propiedades
    {
        public string Titulo { get; set; }
        public int NoColegiado { get; set; }
        public Catedratico()
        {
            Titulo = string.Empty;
            NoColegiado = 0;
        }
    }
}
