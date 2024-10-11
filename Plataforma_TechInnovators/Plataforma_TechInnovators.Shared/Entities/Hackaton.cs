using System.ComponentModel.DataAnnotations;

namespace Plataforma_TechInnovators.Shared.Entities
{
    public class Hackaton
    {
        public int Id { get; set; } //Llave primaria

        //------------------Nombre--------------------//

        [Display(Name = "Nombre")]
        [MaxLength(50, ErrorMessage = "El {0} no puede tener mas de 50 caracteres.")]
        [Required(ErrorMessage = "El {1} es obligatorio.")]
        public string Nombre { get; set; }

        //------------------Tema--------------------//

        [Display(Name = "Tema")]
        [MaxLength(50, ErrorMessage = "El {1} no puede tener mas de 50 caracteres.")]
        [Required(ErrorMessage = "El {1} es obligatorio.")]
        public string Tema { get; set; }

        //------------------Organizador--------------------//

        [Display(Name = "Organizador")]
        [MaxLength(50, ErrorMessage = "El {2} no puede tener mas de 50 caracteres.")]
        [Required(ErrorMessage = "El {2} es obligatorio.")]
        public string Organizador { get; set; }

        //------------------Premio--------------------//

        [Display(Name = "Premio")]
        [MaxLength(50, ErrorMessage = "El {3} no puede tener mas de 50 caracteres.")]
        [Required(ErrorMessage = "El {3} es obligatorio.")]
        public string Premio { get; set; }

        //------------------FechaInicio--------------------//

        [Display(Name = "Fecha de inicio")]
        [Required(ErrorMessage = "Esta fecha es obligatorio.")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime FechaInicio { get; set; }

        //------------------FechaFin--------------------//

        [Display(Name = "Fecha de finalizacion")]
        [Required(ErrorMessage = "Esta fecha es obligatorio.")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime FechaFin { get; set; }

        //RELACIONES

        
    }
}
