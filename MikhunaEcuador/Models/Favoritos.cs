//Añadido
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MikhunaEcuador.Models
{
    public class Favoritos
    {
        [Key]
        public int FavoritosID { get; set; }
        public virtual int RecetaID { get; set; }
        [ForeignKey("RecetaID")]
        public virtual Receta Recetas { get; set; }
        public virtual int UsuarioID { get; set; }
        [ForeignKey("UsuarioID")]
        public virtual Usuario Usuarios { get; set; }
    }
}