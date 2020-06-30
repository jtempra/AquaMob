using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AquaMob.Core.Entities
{
    public class AnotacionOTEntity
    {
        public int Id { get; set; }

        [Required]
        public UserEntity Operario {get; set; }

        [Required]
        [MaxLength(250, ErrorMessage = "El camp {0} pot tenir com a maxim {1} caracters")]
        public string Anotacion { get; set; }

        [Required(ErrorMessage = "El camp {0} es obligatori")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime Fecha { get; set; }


        [Display(Name = "Fecha")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm}")]
        public DateTime FechaLocal => Fecha.ToLocalTime();

        public OrdenTrabajoEntity OrdenTrabajo { get; set; }
    }
}
