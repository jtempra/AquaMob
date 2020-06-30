using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using AquaMob.Core.Entities.Data.Enums;

namespace AquaMob.Core.Entities
{
    public class ConceptoOTEntity
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(25, ErrorMessage = "El camp {0} no pot tenir mes de {1} caracters")]
        public string Codigo { get; set; }

        [Required]
        [MaxLength(100, ErrorMessage = "El camp {0} no pot tenir mes de {1} caracters")]
        public string Concepto { get; set; }

        public TipoConceptoOT Tipo { get; set; }

        public ICollection<DetalleOTEntity> DetallesOrdenTrabajo { get; set; }

    }
}
