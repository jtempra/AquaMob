using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AquaMob.Core.Entities
{
    public class EquipoOTEntity
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "El camp {0} ha de tenir com a maxim {1} caracters")]
        public string Equipo { get; set; }

        [MaxLength(250, ErrorMessage = "El camp {0} ha de tenir com a maxim {1} caracters")]
        public string Observaciones { get; set; }

        public ICollection<OrdenTrabajoEntity> OrdenesTrabajo { get; set; }

        public SubinstalacionOTEntity Subinstalacion { get; set; }
    }
}
