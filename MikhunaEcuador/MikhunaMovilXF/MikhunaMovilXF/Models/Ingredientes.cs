namespace MikhunaMovilXF.Models
{
    public partial class Ingredientes
    {
        public int IngredienteID { get; set; }

        public string Nombre { get; set; }

        public string Unidad { get; set; }

        public int RecetaID { get; set; }

        public virtual Recetas Recetas { get; set; }
    }
}
