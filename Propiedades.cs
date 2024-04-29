namespace Laboratorio10
{
    public class Propiedades
    {
        //Proyecto principal
        //
        public  string Nombre {  get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public DateTime FechaNa { get; set; }
        public int Edad {  get; set; }
        public Propiedades()
        {
            Nombre = string.Empty;
            Apellido = string.Empty;
            Direccion = string.Empty;
            Edad = 0;
        }
        public int CalcularEdad()
        {
             TimeSpan CalculoEdad = FechaNa- DateTime.Now;
            int edad =  int.Parse(CalculoEdad.ToString());
            return edad;
        }

    }
}
