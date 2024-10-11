using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Plataforma_TechInnovators.Shared.Entities
{
    public class Proyecto
    {
        // Primary key - autoincrement
        public int Id { get; set; }


        [Display(Name = "Nombre del proyecto")]
        [MaxLength(50, ErrorMessage = "El {0} no puede tener mas de 50 caracteres.")]
        [Required(ErrorMessage = "El {0} es obligatorio.")]
        public string Name { get; set; }


        [Display(Name = "Descripcion del proyecto")]
        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "El {1} es obligatorio.")]
        public string Descripcion { get; set; }


        [Display(Name = "Estado de desarrollo del proyecto")]
        [MaxLength(20, ErrorMessage = "El {2} no puede tener mas de 20 caracteres.")]
        [Required(ErrorMessage = "El {2} es obligatorio.")]
        public string Estado { get; set; }


        [Display(Name = "Fecha de entrega final")]
        [Required(ErrorMessage = "Esta fecha es obligatorio.")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime FechaEntrega { get; set; }

        //RELACIONES
        [JsonIgnore]
        public Equipo Equipo { get; set; } //Recibe Llave Foranea
        public int IdEquipo { get; set; }

        [JsonIgnore]
        public ICollection<Evaluacion> Evaluaciones { get; set; } //Envia a Evaluacion

    }
}
