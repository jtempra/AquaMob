using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AquaMob.Core.Entities
{
    public class PoblacionOTEntity
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(10, ErrorMessage = "El camp {0} no pot tenir mes de {1} caracters")]
        [Display(Name = "Codi Poblacio")]
        public string Codigo { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "El camp {0} ha de ser com a maxim de {1} caracters")]
        public string Poblacion { get; set; }

        public ICollection<CalleOTEntity> Calles { get; set; }

        public ICollection<ZonaOTEntity> Zonas { get; set; }

        public ICollection<OrdenTrabajoEntity> OrdenesTrabajo { get; set; }

        public ICollection<InstalacionOTEntity> Instalaciones { get; set; }
    }
}
