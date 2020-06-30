using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AquaMob.Core.Entities
{
    public class HistoricoLecturasEntity
    {
        public int Id { get; set; }

        [Required]
        public int NumeroContrato { get; set; }

        [Required]
        public int Periodo { get; set; }
        public double Lectura { get; set; }

        [Required(ErrorMessage = "El camp {0} es obligatori")]
        [Display(Name = "Fecha Lectura")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime FechaLectura { get; set; }


        [Display(Name = "Fecha Lectura")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm}")]
        public DateTime FechaLecturaLocal => FechaLectura.ToLocalTime();

        public double ConsumoLectura { get; set; }
        public double ConsumoImputado { get; set; }
        public double ConsumoEstimado { get; set; }
        public double ConsumoFacturado { get; set; }
        public TipoIncidenciaLecturaEntity IncidenciaLectura { get; set; }
    }
}
