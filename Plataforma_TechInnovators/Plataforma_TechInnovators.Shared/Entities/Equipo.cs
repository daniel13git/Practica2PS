using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Plataforma_TechInnovators.Shared.Entities
{
    public class Equipo
    {
        public int Id { get; set; }


        [Display(Name = "Nombre del equipo")]
        [MaxLength(50, ErrorMessage = "El {0} no puede tener mas de 50 caracteres.")]
        [Required(ErrorMessage = "El {0} es obligatorio.")]
        public string Nombre { get; set; }



        [Display(Name = "Cantidad de miembros del equipo")]
        [MaxLength(2, ErrorMessage = "La {1} no puede tener mas de 2 caracteres.")]
        [Required(ErrorMessage = "La {1} es obligatorio.")]
        public string CantidadMiembros { get; set; }



        [Display(Name = "Experiencia del equipo en meses")]
        [MaxLength(3, ErrorMessage = "La {2} no puede tener mas de 3 caracteres.")]
        [Required(ErrorMessage = "La {2} es obligatorio.")]
        public string Experiencia { get; set; }

        //RELACIONES

        [JsonIgnore]
        public Hackaton Hackaton { get; set; } //Recibe Llave Foranea
        public int IdHackaton { get; set; }

        public Mentor Mentor { get; set; } //Recibe Llave Foranea
        public int IdMentor { get; set; }
        


    }
}
