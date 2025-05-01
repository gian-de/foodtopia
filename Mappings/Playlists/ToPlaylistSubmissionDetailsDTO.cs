using foodtopia.DTOs.Country;
using foodtopia.DTOs.Playlist.Submission;
using foodtopia.DTOs.Recipe;
using foodtopia.DTOs.User;
using foodtopia.Models;

namespace foodtopia.Mappings.Playlists
{
    public static class ToPlaylistSubmissionDetails
    {
        public static PlaylistSubmissionDetailsDTO ToPlaylistSubmissionDetailsDTO(this Playlist playlistModel, string visibilityStatusArgument)
        {
            var visibilityReview = playlistModel.VisibilityReviews
                                    .Where(vr => vr.VisibilityStatus.ToLower() == visibilityStatusArgument.ToLower())
                                    .OrderByDescending(vr => vr.SubmittedAt)
                                    .FirstOrDefault();

            return new PlaylistSubmissionDetailsDTO(
                PlaylistId: playlistModel.Id,
                Name: playlistModel.Name,
                FullSlug: playlistModel.FullSlug,
                CreatedAt: playlistModel.CreatedAt,
                VisibilityStatus: playlistModel.VisibilityStatus,
                HeartedByCount: playlistModel.HeartedByUsers.Count,
                RecipeCount: playlistModel.PlaylistRecipes.Count,
                SubmittedAt: visibilityReview?.SubmittedAt,
                ReviewedAt: visibilityReview?.ReviewedAt,
                ReviewedByUsername: visibilityReview?.ReviewedBy?.UserName,
                User: new UserTldrDTO(playlistModel.User.UserName),
                Recipes: playlistModel.PlaylistRecipes
                    .Select(pr => new RecipeTldrDTO(
                        Id: pr.Recipe.Id,
                        UserName: pr.Recipe.User?.UserName,
                        Name: pr.Recipe.Name,
                        CountryId: pr.Recipe.CountryId,
                        Country: new CountryDTO(
                                    pr.Recipe.Country!.Id,
                                    pr.Recipe.Country.Name,
                                    pr.Recipe.Country.Slug,
                                    pr.Recipe.Country.ImagePath,
                                    Recipes: null),
                        ImageUrl: pr.Recipe.ImageUrl,
                        TasteAverage: pr.Recipe.Ratings.Count > 0 ? (decimal)Math.Round(pr.Recipe.Ratings.Average(r => r.TasteRating), 2) : 0m,
                        DifficultyAverage: pr.Recipe.Ratings.Count > 0 ? (decimal)Math.Round(pr.Recipe.Ratings.Average(r => r.DifficultyRating), 2) : 0m,
                        HeartCount: pr.Recipe.HeartedByUsers.Count
                    ))
                    .ToList()
            );
        }
    }
}