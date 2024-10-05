using Hackaton.Shared.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackaton.SHARED.Entities
{
    public class Mentor
    {
        // Primary key - autoincrement
        public int Id { get; set; }

        [Display(Name = "Documento de identidad")]
        [MaxLength(10, ErrorMessage = "El {0} no puede tener mas de 10 caracteres.")]
        [Required(ErrorMessage = "El {0} es obligatorio.")]
        public string Document { get; set; }


        [Display(Name = "Nombre del mentor")]
        [MaxLength(50, ErrorMessage = "El {1} no puede tener mas de 50 caracteres.")]
        [Required(ErrorMessage = "El {1} es obligatorio.")]
        public string Name { get; set; }


        [Display(Name = "Area experta del mentor")]
        [MaxLength(50, ErrorMessage = "El {2} no puede tener mas de 50 caracteres.")]
        [Required(ErrorMessage = "El {2} es obligatorio.")]
        public string AreaExperta { get; set; }

        public Hackaton Hackaton { get; set; } //RECIBE LLAVE FORANEA DE HACKATON
        public int HackatonId { get; set; }

        public ICollection<Evaluacion> Evaluacion { get; set; }  //ENVIA FORANEA A EVALUACION



    }
}
