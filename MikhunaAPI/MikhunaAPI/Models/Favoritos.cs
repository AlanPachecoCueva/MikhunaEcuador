namespace MikhunaAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Favoritos
    {
        public int FavoritosID { get; set; }
        public int Calificacion { get; set; }

        public int RecetaID { get; set; }

        public int UsuarioID { get; set; }

        public virtual Recetas Recetas { get; set; }

        public virtual Usuarios Usuarios { get; set; }
    }
}
