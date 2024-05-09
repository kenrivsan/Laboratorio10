using System.ComponentModel.DataAnnotations;

namespace Laboratorio10
{
    
    public class Catedratico : Propiedades
    {
        [Required(ErrorMessage = "El titulo es requerido")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "El colegiado")]
        [StringLength(6,
        ErrorMessage = "Deben ser menor de 6 dijitos")]

        public string NoColegiado { get; set; }
        public Catedratico()
        {
            Titulo = string.Empty;
            NoColegiado ="";
        }
    }
}
