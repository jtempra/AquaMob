using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using AquaMob.Core.Entities.Data.Enums;

namespace AquaMob.Core.Entities
{
    public class IncidenciaEntity
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El camp {0} es obligatori")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime Fecha { get; set; }

        [Display(Name = "Fecha")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm}")]
        public DateTime FechaLocal => Fecha.ToLocalTime();

        [Required]
        public PrioridadIncidencia Prioridad { get; set; }

        [Required]
        public TipoSituacionIncidencia Situacion { get; set; }

        [Required(ErrorMessage = "El camp {0} es obligatori")]
        [Display(Name = "Fecha Situacion")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime FechaSituacion { get; set; }

        [Display(Name = "Fecha Situacion")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm}")]
        public DateTime FechaSituacionLocal => FechaSituacion.ToLocalTime();

        [Required]
        [MaxLength (250, ErrorMessage = "El camp {0} ha de tenir com a maxim {1} caracters")]
        public string Direccion { get; set; }

        [MaxLength(250, ErrorMessage = "El camp {0} ha de tenir com a maxim {1} caracters")]
        public string Localizacion { get; set; }

        [Required]
        [MaxLength(500, ErrorMessage = "El camp {0} ha de tenir com a maxim {1} caracters")]
        public string Descripcion { get; set; }

        [MaxLength(500, ErrorMessage = "El camp {0} ha de tenir com a maxim {1} caracters")]
        public string Solucion { get; set; }

        [MaxLength(500, ErrorMessage = "El camp {0} ha de tenir com a maxim {1} caracters")]
        public string Observaciones { get; set; }
        public double Latitud { get; set; }
        public double Longitud { get; set; }
        public bool CreadaApp { get; set; }

        public int NumeroContrato { get; set; }

        [Required]
        [MaxLength(100, ErrorMessage = "El camp {0} ha de tenir com a maxim {1} caracters")]
        public string NombreAbonado { get; set; }

        [MaxLength(15, ErrorMessage = "El camp {0} ha de tenir com a maxim {1} caracters")]
        public string MovilAbonado { get; set; }

        [MaxLength(100, ErrorMessage = "El camp {0} ha de tenir com a maxim {1} caracters")]
        public string EMailAbonado { get; set; }

        [Required]
        public TipoOrigenIncidenciaEntity Origen { get; set; }
        public ICollection<FotoEntity> Fotos { get; set; }

        [Required]
        public UserEntity Operario { get; set; }

        [Required]
        public TipoIncidenciaEntity Tipo { get; set; }
    }
}
