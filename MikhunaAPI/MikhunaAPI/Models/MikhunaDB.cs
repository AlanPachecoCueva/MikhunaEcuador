using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace MikhunaAPI.Models
{
    public partial class MikhunaDB : DbContext
    {
        public MikhunaDB()
            : base("name=MikhunaDB")
        {
        }

        public virtual DbSet<Calificacions> Calificacions { get; set; }
        public virtual DbSet<Comentarios> Comentarios { get; set; }
        public virtual DbSet<Favoritos> Favoritos { get; set; }
        public virtual DbSet<Ingredientes> Ingredientes { get; set; }
        public virtual DbSet<Pasos> Pasos { get; set; }
        public virtual DbSet<Recetas> Recetas { get; set; }
        public virtual DbSet<RecetasTerminadas> RecetasTerminadas { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelbuilder.entity<recetas>()
            //    .hasmany(e => e.calificacions)
            //    .withrequired(e => e.recetas)
            //    .willcascadeondelete(false);

            //modelbuilder.entity<recetas>()
            //    .hasmany(e => e.comentarios)
            //    .withrequired(e => e.recetas)
            //    .willcascadeondelete(false);

            //modelbuilder.entity<recetas>()
            //    .hasmany(e => e.favoritos)
            //    .withrequired(e => e.recetas)
            //    .willcascadeondelete(false);

            //modelbuilder.entity<recetas>()
            //    .hasmany(e => e.ingredientes)
            //    .withrequired(e => e.recetas)
            //    .willcascadeondelete(false);

            //modelbuilder.entity<recetas>()
            //    .hasmany(e => e.pasos)
            //    .withrequired(e => e.recetas)
            //    .willcascadeondelete(false);

            //modelbuilder.entity<recetas>()
            //    .hasmany(e => e.recetasterminadas)
            //    .withrequired(e => e.recetas)
            //    .willcascadeondelete(false);

            //modelbuilder.entity<usuarios>()
            //    .hasmany(e => e.calificacions)
            //    .withrequired(e => e.usuarios)
            //    .willcascadeondelete(false);

            //modelbuilder.entity<usuarios>()
            //    .hasmany(e => e.comentarios)
            //    .withrequired(e => e.usuarios)
            //    .willcascadeondelete(false);

            //modelbuilder.entity<usuarios>()
            //    .hasmany(e => e.favoritos)
            //    .withrequired(e => e.usuarios)
            //    .willcascadeondelete(false);

            //modelbuilder.entity<usuarios>()
            //    .hasmany(e => e.recetasterminadas)
            //    .withrequired(e => e.usuarios)
            //    .willcascadeondelete(false);
        }
    }
}
