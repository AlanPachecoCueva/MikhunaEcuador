//Añadido
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace MikhunaEcuador.Models
{
    public class Receta
    {

        [Key]
        public int RecetaID { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2)]
        [RegularExpression("^[a-zA-Z ]*$", ErrorMessage = "Debe ingresar solo letras")]
        public string Nombre { get; set; }

        [Required]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Debe ingresar solo números")]
        public float Duracion { get; set; }

        [StringLength(400)]
        public string UrlImagen { get; set; }

        public float CalificacionPromedio { get; set; } //Cambiar para que calcule con las calificaciones

        //Enlace con las calificaciones
        public ICollection<Calificacion> Calificaciones { get; set; }

}
}
        