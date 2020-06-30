using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AquaMob.Core.Entities
{
    public class TipoOrigenIncidenciaEntity
    {
        public int Id { get; set; }
        public string OrigenIncidencia { get; set; }
        public string Observaciones { get; set; }

        public ICollection <IncidenciaEntity> Incidencias { get; set; }
    }
}
