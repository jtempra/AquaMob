using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AquaMob.Core.Entities
{
    public class TipoIncidenciaEntity
    {
 
        public int Id { get; set; }

        [Required]
        [MaxLength(10, ErrorMessage = "El camp {0} ha de tenir com a maxim {1} caracters")]
        public string CodigoTipo { get; set; }

        [Required]
        [MaxLength(100, ErrorMessage = "El camp {0} ha de tenir com a maxim {1} caracters")]
        public string Tipo { get; set; }

        [MaxLength(250, ErrorMessage = "El camp {0} ha de tenir com a maxim {1} caracters")]
        public string Observaciones { get; set; }

        public ICollection <IncidenciaEntity> Incidencias { get; set; }
        
    }
}
