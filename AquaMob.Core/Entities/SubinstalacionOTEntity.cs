﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AquaMob.Core.Entities
{
    public class SubinstalacionOTEntity
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "El camp {0} ha de tenir com a màxim {1} caracters")]
        public string Subinstalacion { get; set; }

        [Required]
        [MaxLength(250, ErrorMessage = "El camp {0} ha de tenir com a màxim {1} caracters")]
        public string Observaciones { get; set; }

        public InstalacionOTEntity Instalacion { get; set; }

        public ICollection<EquipoOTEntity> Equipos { get; set; }
    }
}
