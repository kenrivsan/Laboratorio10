namespace Laboratorio10
{
    public class Administrativo : Propiedades
    {
        public string Profesion {  get; set; }
        public int NoIGSS {  get; set; }

        public Administrativo()
        {
            Profesion = string.Empty;
            NoIGSS = 0;

        }
    }
}
