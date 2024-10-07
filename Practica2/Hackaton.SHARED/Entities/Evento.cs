using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Hackaton.SHARED.Entities
{
    public class Evento
    {
        // Primary key - autoincrement
        public int Id { get; set; }

        [Display(Name = "Identificacion")]
        [MaxLength(10, ErrorMessage = "El {0} no puede tener mas de 10 caracteres.")]
        [Required(ErrorMessage = "El {0} es obligatorio.")]
        public string Document { get; set; }


        [Display(Name = "Nombre")]
        [MaxLength(50, ErrorMessage = "El {1} no puede tener mas de 50 caracteres.")]
        [Required(ErrorMessage = "El {1} es obligatorio.")]
        public string Name { get; set; }


        [Display(Name = "Tema")]
        [MaxLength(50, ErrorMessage = "El {2} no puede tener mas de 50 caracteres.")]
        [Required(ErrorMessage = "El {2} es obligatorio.")]
        public string Tema { get; set; }


        [Display(Name = "Organizador")]
        [MaxLength(50, ErrorMessage = "El {3} no puede tener mas de 50 caracteres.")]
        [Required(ErrorMessage = "El {3} es obligatorio.")]
        public string Organizador { get; set; }

        [Display(Name = "Premio")]
        [MaxLength(50, ErrorMessage = "El {4} no puede tener mas de 50 caracteres.")]
        [Required(ErrorMessage = "El {4} es obligatorio.")]
        public string Premio { get; set; }


        [Display(Name = "Fecha de inicio")]
        [Required(ErrorMessage = "Esta fecha es obligatorio.")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime FechaInicio { get; set; }


        [Display(Name = "Fecha de finalizacion")]
        [Required(ErrorMessage = "Esta fecha es obligatorio.")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime FechaFin { get; set; }


        [JsonIgnore]
        public ICollection<Equipo> Equipo { get; set; }  //ENVIA FORANEA A EQUIPO
        

    }
}
