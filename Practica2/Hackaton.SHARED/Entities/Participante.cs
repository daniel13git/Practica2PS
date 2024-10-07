using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Hackaton.SHARED.Entities
{
    public class Participante
    {
        // Primary key - autoincrement
        public int Id { get; set; }

        [Display(Name = "Documento de identidad")]
        [MaxLength(10, ErrorMessage = "El {0} no puede tener mas de 10 caracteres.")]
        [Required(ErrorMessage = "El {0} es obligatorio.")]
        public string Document { get; set; }


        [Display(Name = "Nombre del participante")]
        [MaxLength(50, ErrorMessage = "El {1} no puede tener mas de 50 caracteres.")]
        [Required(ErrorMessage = "El {1} es obligatorio.")]
        public string Name { get; set; }


        [Display(Name = "Rol del participante")]
        [MaxLength(30, ErrorMessage = "El {2} no puede tener mas de 30 caracteres.")]
        [Required(ErrorMessage = "El {2} es obligatorio.")]
        public string Rol { get; set; }


        [Display(Name = "Area del participante")]
        [MaxLength(20, ErrorMessage = "El {3} no puede tener mas de 20 caracteres.")]
        [Required(ErrorMessage = "El {3} es obligatorio.")]
        public string Area { get; set; }

        [JsonIgnore]
        public Equipo Equipo { get; set; } //RECIBE LLAVE FORANEA DE EQUIPO
        public int EquipoId { get; set; }

    }
}
