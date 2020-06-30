using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using AquaMob.Core.Entities.Data.Enums;

namespace AquaMob.Core.Entities
{
    public class RutaLecturaEntity
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(10, ErrorMessage = "El camp {0} ha de tenir com a maxim {1} caracters")]
        public string Codigo { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "El camp {0} ha de tenir com a maxim {1} caracters")]
        public string Nombre { get; set; }
        public int NumeroLecturas { get; set; }
        public int NumeroLeidas { get; set; }
        public TipoSituacionRutaLectura Situacion { get; set; }

        [Display(Name = "Fecha Inicio")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime? FechaInicio { get; set; }

        [Display(Name = "Fecha Inicio")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm}")]
        public DateTime? FechaInicioLocal => FechaInicio.HasValue ? FechaInicio.Value.ToLocalTime() : FechaInicio;

        [Display(Name = "Fecha Fin")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime? FechaFin { get; set; }

        [Display(Name = "Fecha Fin")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm}")]
        public DateTime? FechaFinLocal => FechaFin.HasValue ? FechaFin.Value.ToLocalTime() : FechaFin;

        public ICollection<LecturaEntity> Lecturas { get; set; }
    }
}
