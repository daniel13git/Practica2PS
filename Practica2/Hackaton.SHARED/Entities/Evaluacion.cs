using Hackaton.SHARED.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Hackaton.Shared.Entities
{
    public class Evaluacion
    {
        // Primary key - autoincrement
        public int Id { get; set; }


        [Display(Name = "Puntaje de Evaluacion")]
        [MaxLength(50, ErrorMessage = "El {0} no puede tener mas de 50 caracteres.")]
        [Required(ErrorMessage = "El {0} es obligatorio.")]
        public string Puntaje { get; set; }

        [Display(Name = "Observaciones y/o comentarios")]
        [DataType(DataType.MultilineText)]
        public string Comentarios { get; set; }


        //RELACION FORNAEA CON HACKATON
        [JsonIgnore]
        public Mentor Mentor { get; set; } //RECIBE LLAVE FORANEA DE MENTOR
        public int MentorId { get; set; }

        [JsonIgnore]
        public Proyecto Proyecto { get; set; } //RECIBE LLAVE FORANEA DE PROYECTO
        public int ProyectoId { get; set; }


    }
}
