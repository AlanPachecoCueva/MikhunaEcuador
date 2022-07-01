namespace MikhunaMovilXF.Models
{
    using System.Collections.Generic;

    public partial class Recetas
    {
        public int RecetaID { get; set; }

        public string Nombre { get; set; }

        public float Duracion { get; set; }

        public string UrlImagen { get; set; }

        public float CalificacionPromedio { get; set; }

         public virtual ICollection<Calificacions> Calificacions { get; set; }

        public virtual ICollection<Comentarios> Comentarios { get; set; }

        public virtual ICollection<Favoritos> Favoritos { get; set; }

        public virtual ICollection<Ingredientes> Ingredientes { get; set; }

        public virtual ICollection<Pasos> Pasos { get; set; }

        public virtual ICollection<RecetasTerminadas> RecetasTerminadas { get; set; }
    }
}
