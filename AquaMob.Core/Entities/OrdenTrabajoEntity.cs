using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using AquaMob.Core.Entities.Data.Enums;

namespace AquaMob.Core.Entities
{
    public class OrdenTrabajoEntity
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El tipus de OT es obligatori")]
        public TipoOTEntity Tipo { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Fecha { get; set; }

        [Display(Name = "Fecha")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime FechaLocal => Fecha.ToLocalTime();

        public string ResponsableId { get; set; }

        [ForeignKey("ResponsableId")]
        public UserEntity Responsable { get; set; }

        public string CreadorId { get; set; }

        [ForeignKey("CreadorId")]
        public UserEntity Creador { get; set; }

        [Required]
        public TipoSituacionOT Situacion { get; set; }

        [Required]
        [Display(Name = "Fecha Situacion")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime FechaSituacion { get; set; }

        [Display(Name = "Fecha Situacion")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm}")]
        public DateTime FechaSituacionLocal => FechaSituacion.ToLocalTime();

        [Required]
        [MaxLength(1000, ErrorMessage = "El camp {0} ha de tenir màxim {1} caracters")]
        public string Descripcion { get; set; }

        [MaxLength(1000, ErrorMessage = "El camp {0} ha de tenir màxim {1} caracters")]
        public string Trabajos { get; set; }

        public ICollection<AnotacionOTEntity> Anotaciones { get; set; }

        public PoblacionOTEntity Poblacion { get; set; }

        public CalleOTEntity Calle { get; set; }

        public ZonaOTEntity Zona { get; set; }

        [Required]
        [MaxLength(250, ErrorMessage = "El camp {0} ha de tenir màxim {1} caracters")]
        public string Direccion { get; set; }

        [Display(Name = "Direccion Adicional")]
        [MaxLength(250, ErrorMessage = "El camp {0} ha de tenir màxim {1} caracters")]
        public string DireccionAdicional { get; set; }

        [Display(Name = "Numero Contrato")]
        [MaxLength(20, ErrorMessage = "El camp {0} ha de tenir màxim {1} caracters")]
        public int NumeroContrato { get; set; }

        [Display(Name = "Nombre Abonado")]
        [MaxLength(50, ErrorMessage = "El camp {0} ha de tenir màxim {1} caracters")]
        public string NombreAbonado { get; set; }

        [Display(Name = "Movil Cliente")]
        [MaxLength(20, ErrorMessage = "El camp {0} ha de tenir màxim {1} caracters")]
        public string MovilCliente { get; set; }

        [Display(Name = "EMail Cliente")]
        [MaxLength(100, ErrorMessage = "El camp {0} ha de tenir màxim {1} caracters")]
        public string EMailCliente { get; set; }

        [Required]
        public PrioridadOT Prioridad { get; set; }

        public double? Latitud { get; set; }

        public double? Longitud { get; set; }

        public InstalacionOTEntity Instalacion { get; set; }

        public SubinstalacionOTEntity SubInstalacion { get; set; }

        public EquipoOTEntity Equipo { get; set; }

        public Boolean CreadaApp { get; set; }

        public Boolean Recurrente { get; set; }

        public Boolean Generica { get; set; }

        public Boolean PendienteObras { get; set; }

        public ICollection<DetalleOTEntity> DetallesOrdenTrabajo { get; set; }

        public ICollection<FotoEntity> Fotos { get; set; }      
    }
}
