using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AquaMob.Core.Entities
{
    public class DetalleOTEntity
    {
        public int Id { get; set; }

        public OrdenTrabajoEntity OrdenTrabajo { get; set; }

        public ConceptoOTEntity Concepto { get; set; }

        public UserEntity  Operario { get; set; }

        public double Cantidad { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime Fecha { get; set; }

        [Display(Name = "Fecha")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm}")]
        public DateTime FechaLocal => Fecha.ToLocalTime();

        public Boolean Validado { get; set; }
    }
}
