using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AquaMob.Core.Entities
{
    public class CalleOTEntity
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(10, ErrorMessage = "El camp {0} no pot tenir mes de {1} caracters")]
        [Display(Name = "Codi Carrer")]
        public string Codigo { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "El camp {0} no pot ser mes llarg de {1} caracters")]
        public string Calle { get; set; }

        public PoblacionOTEntity Poblacion { get; set; }

        public ICollection<OrdenTrabajoEntity> OrdenesTrabajo { get; set; }
    }
}
