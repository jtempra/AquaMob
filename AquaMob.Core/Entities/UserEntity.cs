using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using AquaMob.Core.Entities.Data.Enums;

namespace AquaMob.Core.Entities
{
    public class UserEntity: IdentityUser
    {
        public string NIF { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        public string Movil { get; set; }
        public string PathFoto { get; set; }
        public TipoUsuario Tipo { get; set; }
        public string NombreCompleto => $"{Nombre} {Apellidos}";
        public ICollection<LecturaEntity> Lecturas { get; set; }

        public ICollection<IncidenciaEntity> Incidencias { get; set; }

        [InverseProperty("Creador")]
        public ICollection<OrdenTrabajoEntity> OrdenesTrabajoCreadas { get; set; }

        [InverseProperty("Responsable")]
        public ICollection<OrdenTrabajoEntity> OrdenesTrabajoGestionadas { get; set; }
    }
}
