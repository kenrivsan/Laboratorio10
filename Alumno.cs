using System.Runtime.CompilerServices;

namespace Laboratorio10
{
    public class Alumno : Propiedades
    {
        public int NoCarnet { get; set; }
        public int NoNotas { set; get; }
        public Alumno() 
        { 
            NoCarnet = 0;
            NoNotas = 0;
        }

    }
}
