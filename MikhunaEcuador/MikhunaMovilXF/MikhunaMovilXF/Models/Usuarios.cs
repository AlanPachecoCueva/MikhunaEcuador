namespace MikhunaMovilXF.Models
{
    using System.Collections.Generic;

    public partial class Usuarios
    {
        public int UsuarioID { get; set; }

        public string NickName { get; set; }

        public string Correo { get; set; }

        public string Clave { get; set; }

        public int Nivel { get; set; }
        public string Imagen { get; set; }

        public virtual ICollection<Calificacions> Calificacions { get; set; }

        public virtual ICollection<Comentarios> Comentarios { get; set; }

        public virtual ICollection<Favoritos> Favoritos { get; set; }

        public virtual ICollection<RecetasTerminadas> RecetasTerminadas { get; set; }
    }
}
