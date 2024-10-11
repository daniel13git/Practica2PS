using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Plataforma_TechInnovators.Shared.Entities
{
    public class Mentor
    {
        // Primary key - autoincrement
        public int Id { get; set; }


        [Display(Name = "Nombre del mentor")]
        [MaxLength(50, ErrorMessage = "El {0} no puede tener mas de 50 caracteres.")]
        [Required(ErrorMessage = "El {0} es obligatorio.")]
        public string Nombre { get; set; }


        [Display(Name = "Area experta del mentor")]
        [MaxLength(50, ErrorMessage = "El {1} no puede tener mas de 50 caracteres.")]
        [Required(ErrorMessage = "El {1} es obligatorio.")]
        public string AreaExperta { get; set; }


        [Display(Name = "Experiencia del Mentor en meses")]
        [MaxLength(3, ErrorMessage = "El {2} no puede tener mas de 3 digitos.")]
        [Required(ErrorMessage = "El {2} es obligatorio.")]
        public string Experiencia { get; set; }


        //RELACIONES
        [JsonIgnore]
        public Hackaton Hackaton { get; set; } //Recibe Llave Foranea
        public int IdHackaton { get; set; }

        [JsonIgnore]
        public ICollection<Evaluacion> Evaluaciones { get; set; } //Envia a Evaluacion
    }
}
