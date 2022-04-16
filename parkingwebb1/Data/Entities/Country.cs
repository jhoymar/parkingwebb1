using System.ComponentModel.DataAnnotations;

namespace parkingwebb1.Data.Entities
{
    public class Country
    { 
            public int Id { get; set; }

            [Display(Name = "Instalaciones")]
            [MaxLength(50, ErrorMessage = "El campo {0} debe tener maximo{1} caracteres.")]
            [Required(ErrorMessage = "El campo {0} es obligatorio. ")]
            public string Name { get; set; }


        }
    }
