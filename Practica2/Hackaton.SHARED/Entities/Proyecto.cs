using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackaton.SHARED.Entities
{
    public class Proyecto
    {
        // Primary key - autoincrement
        public int Id { get; set; }

        [Display(Name = "Documento de identidad")]
        [MaxLength(10, ErrorMessage = "El {0} no puede tener mas de 10 caracteres.")]
        [Required(ErrorMessage = "El {0} es obligatorio.")]
        public string Document { get; set; }


        [Display(Name = "Nombre del proyecto")]
        [MaxLength(50, ErrorMessage = "El {1} no puede tener mas de 50 caracteres.")]
        [Required(ErrorMessage = "El {1} es obligatorio.")]
        public string Name { get; set; }


        [Display(Name = "Descripcion del proyecto")]
        [MaxLength(100, ErrorMessage = "El {2} no puede tener mas de 100 caracteres.")]
        [Required(ErrorMessage = "El {2} es obligatorio.")]
        public string Descripcion { get; set; }


        [Display(Name = "Estado de desarrollo del proyecto")]
        [MaxLength(20, ErrorMessage = "El {3} no puede tener mas de 20 caracteres.")]
        [Required(ErrorMessage = "El {3} es obligatorio.")]
        public string Estado { get; set; }


        [Display(Name = "Fecha de entrega fianl")]
        [Required(ErrorMessage = "Esta fecha es obligatorio.")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime FechaEntrega { get; set; }
    }
}
