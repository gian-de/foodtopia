using System.ComponentModel.DataAnnotations;

namespace foodtopia.Models
{
    public class Ingredient
    {
        public Guid Id { get; set; }
        public Guid RecpieId { get; set; }
        [Required(ErrorMessage = "Ingredient name is required.")]
        public required string Name { get; set; }

        [Required(ErrorMessage = "Quantity is required")]
        public decimal Quantity { get; set; }

        public required Recipe Recipe { get; set; }
    }
}