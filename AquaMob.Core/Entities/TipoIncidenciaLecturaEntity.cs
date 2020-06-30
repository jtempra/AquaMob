using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AquaMob.Core.Entities
{
    public class TipoIncidenciaLecturaEntity
    {
        public int Id { get; set; }
        public string CodigoIncidencia { get; set; }
        public string Incidencia  { get; set; }
        public string Observaciones { get; set; }
        public ICollection<LecturaEntity> Lecturas { get; set; }

    }
}
