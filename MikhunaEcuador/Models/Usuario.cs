//Añadido
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MikhunaEcuador.Models
{
    public class Usuario
    {
        [Key]
        public int UsuarioID { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2)]
        [RegularExpression("^[a-zA-Z ]*$", ErrorMessage = "Debe ingresar sol" +
            "o letras.")]
        public string NickName { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 2)]
        [DataType(DataType.EmailAddress)]
        public string Correo { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 8)]
        public string Clave { get; set; }
       




        public int Nivel { get; set; }
        
        //public virtual int RecetaTerminadaID { get; set; }
        //[ForeignKey("RecetaTerminadaID")]
        //public virtual ICollection<RecetasTerminadas> RecetasTerminadas { get; set; }

        //public virtual int FavoritoID { get; set; }
        //[ForeignKey("FavoritoID")]
        //public virtual ICollection<Usuario> Favoritos { get; set; }

    }
}