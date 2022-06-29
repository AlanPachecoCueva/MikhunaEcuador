
//Agregado
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace APIMikhuna.Models
{
    //Yo le agrego el DbContext
    public class MikhunaDB : DbContext
    {
        //Agregado para la API
        //base es la que lleva la conecction string
        public MikhunaDB() :base(@"Server=ALANSSD\SQLEXPRESS; Database=MikhunaDB; integratedsecurity=True;providerName=System.Data.SqlClient")
        {

        }

        //Son las tablas, que también están en el modelo
        public DbSet<Receta> Receta { get; set; }
        public DbSet<Ingrediente> Ingrediente { get; set; }
        public DbSet<Calificacion> Calificacion { get; set; }
        public DbSet<Favoritos> Favoritos { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Pasos> Pasos { get; set; }
        public DbSet<RecetasTerminadas> RecetasTerminadas { get; set; }
        public DbSet<Comentario> Comentario { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

        }

        //Patrón de diseño SingleTon
        //Si voy a trabajar varias veces con esta clase solo genero entonces una instancia
        //public static MikhunaDB Create() {
        //    return new MikhunaDB();
        //}

    }

}