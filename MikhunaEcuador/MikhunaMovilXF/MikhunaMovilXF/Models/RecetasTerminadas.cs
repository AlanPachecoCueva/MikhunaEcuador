namespace MikhunaMovilXF.Models
{
    public partial class RecetasTerminadas
    {
        public int RecetaTerminadaID { get; set; }

        public int RecetaID { get; set; }

        public int UsuarioID { get; set; }

        public virtual Recetas Recetas { get; set; }

        public virtual Usuarios Usuarios { get; set; }
    }
}
