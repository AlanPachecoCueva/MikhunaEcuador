//Añadido
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MikhunaEcuador.Models
{
    public class Pasos
    {
        [Key]
        public int PasosID { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string Paso { get; set; }
        [Required]
        [StringLength(900, MinimumLength = 1)]
        [RegularExpression("^[a-zA-ZÀ-ÿ\u00f1\u00d1]+$")]
        public virtual int RecetaID { get; set; }
        [ForeignKey("RecetaID")]
        public virtual Receta Recetas { get; set; }
    }
}