using foodtopia.DTOs.Recipe;
using foodtopia.Helpers;
using foodtopia.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.RateLimiting;

namespace foodtopia.Controllers
{
    [Route("api/recipes")]
    [ApiController]
    public class RecipeController : ControllerBase
    {
        private readonly IRecipeService _recipeService;
        public RecipeController(IRecipeService recipeService)
        {
            _recipeService = recipeService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllRecipes(
            [FromQuery] int page = 1,
            [FromQuery] int pageSize = 10,
            [FromQuery] string sortBy = "PublishedAt",
            [FromQuery] string sortDirection = "desc",
            [FromQuery] string? username = null)
        {
            try
            {
                var recipePagedResult = await _recipeService.GetAllRecipesAsync(page, pageSize, sortBy, sortDirection, username);

                return Ok(recipePagedResult);
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(new { ex.Message });
            }
            catch (ArgumentException ex)
            {
                return BadRequest(new { ex.Message });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { ex.Message });
            }
        }

        [HttpGet("{recipeId:guid}")]
        public async Task<IActionResult> GetRecipeById([FromRoute] Guid recipeId)
        {
            try
            {
                var recipeDTO = await _recipeService.GetRecipeByIdAsync(recipeId);
                return Ok(recipeDTO);
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(new { ex.Message });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { ex.Message });
            }
        }

        [HttpGet("my")]
        [Authorize]
        public async Task<IActionResult> GetMyCreatedRecipes(
            [FromQuery] int page = 1,
            [FromQuery] int pageSize = 10,
            [FromQuery] string sortBy = "PublishedAt",
            [FromQuery] string sortDirection = "desc")
        {
            try
            {
                var userId = User.GetUserIdFromClaims();

                var myRecipesPagedResult = await _recipeService.GetMyCreatedRecipesAsync(userId, page, pageSize, sortBy, sortDirection);

                return Ok(myRecipesPagedResult);
            }
            catch (UnauthorizedAccessException ex)
            {
                return Unauthorized(new { ex.Message });
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(new { ex.Message });
            }
            catch (ArgumentException ex)
            {
                return BadRequest(new { ex.Message });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { ex.Message });
            }
        }

        [HttpPost]
        [Authorize]
        [EnableRateLimiting("fixed-limiter-strict")]
        public async Task<IActionResult> CreateRecipe([FromBody] RecipeCreateRequestDTO recipeCreateDTO)
        {
            try
            {
                var userId = User.GetUserIdFromClaims();
                var recipeDTO = await _recipeService.CreateRecipeAsync(userId, recipeCreateDTO);

                return CreatedAtAction(nameof(GetRecipeById), new { recipeId = recipeDTO.Id }, recipeDTO);
            }
            catch (UnauthorizedAccessException ex)
            {
                return Unauthorized(new { ex.Message });
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(new { ex.Message });
            }
            catch (ArgumentNullException ex)
            {
                return BadRequest(new { ex.Message });
            }
            catch (ArgumentException ex)
            {
                return NotFound(new { ex.Message });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { ex.Message });
            }
        }

        [HttpPut("{recipeId:guid}")]
        [Authorize]
        [EnableRateLimiting("fixed-limiter-strict")]
        public async Task<IActionResult> UpdateRecipe([FromRoute] Guid recipeId, [FromBody] RecipeUpdateRequestDTO recipeUpdateDTO)
        {
            try
            {
                var userId = User.GetUserIdFromClaims();
                var updatedRecipe = await _recipeService.UpdateRecipeAsync(userId, recipeId, recipeUpdateDTO);

                return Ok(updatedRecipe);
            }
            catch (UnauthorizedAccessException ex)
            {
                return Unauthorized(new { ex.Message });
            }
            catch (ArgumentNullException ex)
            {
                return BadRequest(new { ex.Message });
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(new { ex.Message });
            }
            catch (ArgumentException ex)
            {
                return BadRequest(new { ex.Message });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { ex.Message });
            }
        }

        [HttpDelete("{recipeId:guid}")]
        [Authorize]
        public async Task<IActionResult> DeleteRecipe([FromRoute] Guid recipeId)
        {
            try
            {
                var userId = User.GetUserIdFromClaims();
                var deletedRecipeDTO = await _recipeService.DeleteRecipeAsync(userId, recipeId);

                return Ok(new
                {
                    Message = "Recipe successfully deleted.",
                    DeletedRecipe = deletedRecipeDTO
                });
            }
            catch (UnauthorizedAccessException ex)
            {
                return Unauthorized(new { ex.Message });
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(new { ex.Message });
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        // SUBMISSION FOR REVIEW START
        [Authorize]
        [HttpPost("{recipeId:guid}/submissions")]
        public async Task<IActionResult> CreateRecipeSubmission([FromRoute] Guid recipeId)
        {
            try
            {
                if (User.IsGuest()) return Unauthorized("Only verified users can submit recipes to global.");
                var userId = User.GetUserIdFromClaims();

                var submissionResult = await _recipeService.SubmitRecipeSubmissionAsync(userId, recipeId);

                return Ok(submissionResult);
            }
            catch (UnauthorizedAccessException ex)
            {
                return Unauthorized(new { ex.Message });
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(new { ex.Message });
            }
            catch (ArgumentException ex)
            {
                return BadRequest(new { ex.Message });
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [Authorize]
        [HttpDelete("{recipeId:guid}/submissions")]
        public async Task<IActionResult> UnsubmitRecipeSubmission([FromRoute] Guid recipeId)
        {
            try
            {
                if (User.IsGuest()) return Unauthorized("Only verified users can submit recipes to global.");
                var userId = User.GetUserIdFromClaims();

                var unsubmitResponse = await _recipeService.UnSubmitRecipeSubmissionAsync(userId, recipeId);
                return Ok(unsubmitResponse);
            }
            catch (UnauthorizedAccessException ex)
            {
                return Unauthorized(new { ex.Message });
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(new { ex.Message });
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}