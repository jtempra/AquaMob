using System;
using System.Collections.Generic;
using System.Text;
using AquaMob.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace AquaMob.Infraestructure.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // creem un index per contracte a la taula historic de lectures

            builder.Entity<HistoricoLecturasEntity>()
                .HasIndex(t => t.NumeroContrato);
        }


        public DbSet<AnotacionOTEntity> AnotacionesOrdenesTrabajo { get; set; }
        public DbSet<CalleOTEntity> CallesOrdenesTrabajo { get; set; }
        public DbSet<ConceptoOTEntity> ConceptosOrdenesTrabajo { get; set; }
        public DbSet<DetalleOTEntity> DetallesOrdenesTrabajo { get; set; }
        public DbSet<EquipoOTEntity> EquiposOrdenesTrabajo { get; set; }
        public DbSet<FotoEntity> Fotos { get; set; }
        public DbSet<HistoricoLecturasEntity> HistoricosLecturas { get; set; }
        public DbSet<IncidenciaEntity> Incidencias { get; set; }
        public DbSet<InfoAdicionalOTEntity> InfosAdicionalesOrdenesTrabajo { get; set; }
        public DbSet<InstalacionOTEntity> InstalacionesInstalacionOrdenTrabajo { get; set; }
        public DbSet<LecturaEntity> Lecturas { get; set; }
        public DbSet<OrdenTrabajoEntity> OrdenesTrabajo { get; set; }
        public DbSet<PoblacionOTEntity> PoblacionesOrdenesTrabajo { get; set; }
        public DbSet<RutaLecturaEntity> RutasLectura { get; set; }
        public DbSet<SubinstalacionOTEntity> SubinstalacionesOrdenesTrabajo { get; set; }
        public DbSet<TipoIncidenciaLecturaEntity> TiposIncidenciaLecturas { get; set; }
        public DbSet<TipoIncidenciaEntity> TiposIncidencia { get; set; }
        public DbSet<TipoOTEntity> TiposOrdenesTrabajo { get; set; }
        public DbSet<TipoOrigenIncidenciaEntity> TiposOrigenesIncidencias { get; set; }
        public DbSet<UserEntity> Usuarios { get; set; }
        public DbSet<ZonaOTEntity> ZonasOrdenesTrabajo { get; set; }
    }
}
