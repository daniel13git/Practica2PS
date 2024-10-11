using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Plataforma_TechInnovators.Shared.Entities
{
    public class Evaluacion
    {
        // Primary key - autoincrement
        public int Id { get; set; }


        [Display(Name = "Puntaje de Evaluacion")]
        [MaxLength(100, ErrorMessage = "El {0} no puede tener mas de 100 caracteres.")]
        [Required(ErrorMessage = "El {0} es obligatorio.")]
        public string Puntaje { get; set; }

        [Display(Name = "Observaciones y/o comentarios")]
        [DataType(DataType.MultilineText)]
        public string Comentarios { get; set; }

        //RELACIONES
        [JsonIgnore]
        public Proyecto Proyecto { get; set; } //Recibe Llave Foranea
        public int IdProyecto { get; set; } 
        public Mentor Mentor { get; set; } //Recibe Llave Foranea
        public int IdMentor { get; set; }
    }

    
}