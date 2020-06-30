using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using AquaMob.Core.Entities.Data.Enums;

namespace AquaMob.Core.Entities
{
    public class LecturaEntity
    {
        public int Id { get; set; }

        [Required]
        [Display (Name="Contrato")]
        public int NumeroContrato { get; set; }

        [Required]
        [Display(Name = "Abonado")]
        [MaxLength(100, ErrorMessage = "El camp {0} ha de tenir com a maxim {1} caracters")]
        public string NombreAbonado { get; set; }

        [Display(Name = "Movil Abonado")]
        [MaxLength(15, ErrorMessage = "El camp {0} ha de tenir com a maxim {1} caracters")]
        public string MovilAbonado { get; set; }

        [Display(Name = "Email Abonado")]
        [MaxLength(100, ErrorMessage = "El camp {0} ha de tenir com a maxim {1} caracters")]
        public string EmailAbonado { get; set; }

        [Required]
        [Display(Name = "Direccion Suministro")]
        [MaxLength(100, ErrorMessage = "El camp {0} ha de tenir com a maxim {1} caracters")]
        public string DireccionSuministro { get; set; }

        [Required]
        [Display(Name = "Poblacion")]
        [MaxLength(10, ErrorMessage = "El camp {0} ha de tenir com a maxim {1} caracters")]
        public string PoblacionSuministro { get; set; }

        [Display(Name = "Orden Ruta")]
        [MaxLength(10, ErrorMessage = "El camp {0} ha de tenir com a maxim {1} caracters")]
        public string OrdenRutaLectura { get; set; }

        [Display(Name = "Ubicacion Contador")]
        [MaxLength(100, ErrorMessage = "El camp {0} ha de tenir com a maxim {1} caracters")]
        public string UbicacionContador { get; set; }

        [Display(Name = "Contador")]
        [MaxLength(25, ErrorMessage = "El camp {0} ha de tenir com a maxim {1} caracters")]
        public string NumeroContador { get; set; }

        [Display(Name = "Contador Nuevo")]
        [MaxLength(25, ErrorMessage = "El camp {0} ha de tenir com a maxim {1} caracters")]
        public string NumeroContadorNuevo { get; set; }

        [Display(Name = "Ruta Nueva")]
        [MaxLength(10, ErrorMessage = "El camp {0} ha de tenir com a maxim {1} caracters")]
        public string RutaLecturaNueva { get; set; }

        [Display(Name = "Orden Ruta Nueva")]
        [MaxLength(10, ErrorMessage = "El camp {0} ha de tenir com a maxim {1} caracters")]
        public string OrdenRutaLecturaNueva { get; set; }

        public Double LecturaAnterior { get; set; }

        public Double LecturaActual { get; set; }

        public Double LecturaNuevo { get; set; }

        [Required(ErrorMessage = "El camp {0} es obligatori")]
        [Display(Name = "Fecha Lectura Anterior")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime FechaLecturaAnterior { get; set; }

        [Display(Name = "Fecha Lectura Anterior")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm}")]
        public DateTime FechaLecturaAnteriorLocal => FechaLecturaAnterior.ToLocalTime();

        [Display(Name = "Fecha Lectura Actual")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime FechaLecturaActual { get; set; }

        [Display(Name = "Fecha Lectura Actual")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm}")]
        public DateTime FechaLecturaActualLocal => FechaLecturaActual.ToLocalTime();

        [Display(Name = "Fecha Lectura Nuevo")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime? FechaLecturaNuevo { get; set; }

        [Display(Name = "Fecha Lectura Nuevo")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm}")]
        public DateTime? FechaLecturaNuevoLocal => FechaLecturaNuevo.HasValue ? FechaLecturaNuevo.Value.ToLocalTime() : FechaLecturaNuevo;

        [Required]
        public TipoSituacionLectura SituacionLectura { get; set; }

        [Required]
        public TipoIncidenciaLecturaEntity IncidenciaLectura { get; set; }

        [Required]
        public TipoIncidenciaContador IncidenciaContador { get; set; }

        public double ConsumoAnterior { get; set; }

        public double PromedioConsumo { get; set; }

        [Display(Name = "Observaciones Lectura")]
        [MaxLength(100, ErrorMessage = "El camp {0} ha de tenir com a maxim {1} caracters")]
        public string ObservacionesLectura { get; set; }

        [Display(Name = "Observaciones Suministro")]
        [MaxLength(100, ErrorMessage = "El camp {0} ha de tenir com a maxim {1} caracters")]
        public string ObservacionesSuministro { get; set; }

        public double Latitud { get; set; }

        public double Longitud { get; set; }

        public int Periodo { get; set; }

        [MaxLength(100, ErrorMessage = "El camp {0} ha de tenir com a maxim {1} caracters")]
        public string Codigo1 { get; set; }

        [MaxLength(100, ErrorMessage = "El camp {0} ha de tenir com a maxim {1} caracters")]
        public string Codigo2 { get; set; }

        [MaxLength(100, ErrorMessage = "El camp {0} ha de tenir com a maxim {1} caracters")]
        public string Codigo3 { get; set; }

        public RutaLecturaEntity Ruta { get; set; }

        public ICollection<FotoEntity> Fotos { get; set; }

        public UserEntity Operario { get; set; }
    }
}
