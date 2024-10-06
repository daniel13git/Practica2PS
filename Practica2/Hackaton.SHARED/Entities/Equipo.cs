using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Hackaton.SHARED.Entities
{
    public class Equipo
    {
        // Primary key - autoincrement
        public int Id { get; set; }

        [Display(Name = "Identificacion del equipo")]
        [MaxLength(10, ErrorMessage = "El {0} no puede tener mas de 10 caracteres.")]
        [Required(ErrorMessage = "El {0} es obligatorio.")]
        public string Document { get; set; }

        [Display(Name = "Nombre del equipo")]
        [MaxLength(50, ErrorMessage = "El {1} no puede tener mas de 50 caracteres.")]
        [Required(ErrorMessage = "El {1} es obligatorio.")]
        public string Name { get; set; }

        [Display(Name = "Cantidad de miembros del equipo")]
        [MaxLength(2, ErrorMessage = "El {2} no puede tener mas de 2 caracteres.")]
        [Required(ErrorMessage = "El {2} es obligatorio.")]
        public string CantidadMiembros { get; set; }


        [Display(Name = "Experiencia del equipo en meses")]
        [MaxLength(3, ErrorMessage = "El {3} no puede tener mas de 3 caracteres.")]
        [Required(ErrorMessage = "El {3} es obligatorio.")]
        public string Experiencia { get; set; }

        //RELACIONES
        [JsonIgnore]
        public Evento Evento { get; set; } //RECIBE LLAVE FORANEA DE HACKATON
        public int EventoId { get; set; }


        [JsonIgnore]
        public ICollection <Participante> Participantes { get; set; } //ENVIA FORANEA A PARTICIPANTE

        [JsonIgnore]
        public ICollection<Proyecto> Proyecto { get; set; }  //ENVIA FORANEA A PROYECTO

        

    }
}
