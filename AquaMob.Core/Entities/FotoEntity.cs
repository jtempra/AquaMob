using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AquaMob.Core.Entities
{
    public class FotoEntity
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(250, ErrorMessage = "El camp {0} ha de tenir com a maxim {1} caracters")]
        public string RutaFoto { get; set; }

        public LecturaEntity Lectura { get; set; }
        public OrdenTrabajoEntity  OdenTrabajo { get; set; }
        public IncidenciaEntity  Incidencia { get; set; }
    }
}
