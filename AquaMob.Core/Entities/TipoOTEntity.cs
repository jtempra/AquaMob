using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AquaMob.Core.Entities
    public class TipoOTEntity
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El camp tipus de OT es requerit")]
        [MaxLength(50, ErrorMessage = "El tipus de la OT ha de ser Màx. 50 caracters")]
        public string Tipo { get; set; }

        [MaxLength(100, ErrorMessage = "La descripció del tipus ha de ser Màx. 100 caracters")]
        public string Descripcion { get; set; }

        public ICollection<OrdenTrabajoEntity> OrdenesTrabajo { get; set; }
    }
}
