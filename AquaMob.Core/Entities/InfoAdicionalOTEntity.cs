using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AquaMob.Core.Entities
{
    public class InfoAdicionalOTEntity
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "El camp {0} ha de tenir màxim {1} caracters")]
        public string Clave { get; set; }

        [Required]
        [MaxLength(250, ErrorMessage = "El camp {0} ha de tenir màxim {1} caracters")]
        public string Valor { get; set; }

        public OrdenTrabajoEntity OrdenTrabajo { get; set; }
    }
}
