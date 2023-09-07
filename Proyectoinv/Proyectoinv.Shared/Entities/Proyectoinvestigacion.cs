using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Proyectoinv.Shared.Entities
{
    public class Proyectoinvestigacion
    {
        public int Id { get; set; }

        [Display(Name = "Nombre")]
        [MaxLength(100, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Name { get; set; } = null!;
        
        public DateOnly FechaInicio { get; set; }

        public DateOnly FechaFin { get; set; }

        [Display(Name = "NombreLider")]
        [MaxLength(100, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        public string NombreLider { get; set; } = null!;

        [Display(Name = "Descripcion")]
        [MaxLength(100, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        public string Descripcion { get; set; } = null!;

        [Display(Name = "Area")]
        [MaxLength(100, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        public string Area { get; set; } = null!;
    }

    public class Investigador
    {
        public int Id { get; set; }

        [Display(Name = "Nombre")]
        [MaxLength(100, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Name { get; set; } = null!;

        [Display(Name = "Afiliación")]
        [MaxLength(100, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Afiliacion { get; set; } = null!;

        [Display(Name = "Especialización")]
        [MaxLength(100, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Especializacion { get; set; } = null!;

        [Display(Name = "Rol")]
        [MaxLength(100, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Rol { get; set; } = null!;
    }
}
