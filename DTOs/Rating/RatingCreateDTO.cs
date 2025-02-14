using System.ComponentModel.DataAnnotations;

namespace foodtopia.DTOs.Rating
{
    public class RatingCreateDTO
    {
        [Range(1.0, 5.0)]
        public double TasteRating { get; set; }

        [Range(1.0, 5.0)]
        public double DifficultyRating { get; set; }
    }
}