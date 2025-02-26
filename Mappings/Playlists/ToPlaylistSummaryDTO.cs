using foodtopia.DTOs.Playlist;
using foodtopia.DTOs.Recipe;
using foodtopia.DTOs.User;
using foodtopia.Models;

namespace foodtopia.Mappings.Playlists
{
    public static class PlaylistExtension
    {
        public static PlaylistSummaryDTO ToPlaylistSummaryDTO(this Playlist playlistModel)
        {
            return new PlaylistSummaryDTO
            (
                Id: playlistModel.Id,
                Name: playlistModel.Name,
                FullSlug: playlistModel.FullSlug,
                CreatedAt: playlistModel.CreatedAt,
                HeartedByCount: playlistModel.HeartedByUsers.Count,
                User: new UserTldrDTO(Id: playlistModel.User.Id, Username: playlistModel.User.UserName), // can never be null since auth check only verified users can create a playlist
                Recipes: playlistModel.PlaylistRecipes.Select(pr =>
                    new RecipeTldrDTO(
                        Id: pr.Recipe.Id,
                        UserName: pr.Recipe.User?.UserName,
                        Name: pr.Recipe.Name,
                        CountryId: pr.Recipe.CountryId,
                        ImageUrl: pr.Recipe.ImageUrl,
                        TasteAverage: pr.Recipe.Ratings.Count > 0 ? (decimal)Math.Round(pr.Recipe.Ratings.Average(r => r.TasteRating), 2) : 0m,
                        DifficultyAverage: pr.Recipe.Ratings.Count > 0 ? (decimal)Math.Round(pr.Recipe.Ratings.Average(r => r.DifficultyRating), 2) : 0m,
                        HeartCount: pr.Recipe.HeartedByUsers.Count
                    )).ToList()
            );
        }
    }
}