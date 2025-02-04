using foodtopia.Extensions;
using foodtopia.Interfaces;
using foodtopia.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;


namespace foodtopia.Controllers
{
    [Route("api/hearted-recipes")]
    [ApiController]
    public class HeartedRecipeController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IRecipeService _recipeService;
        private readonly IHeartedRecipeService _heartedRecipeService;
        public HeartedRecipeController(
            UserManager<AppUser> userManager,
            IRecipeService recipeService,
            IHeartedRecipeService heartedRecipeService
            )
        {
            _userManager = userManager;
            _recipeService = recipeService;
            _heartedRecipeService = heartedRecipeService;
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> GetUserHeartedRecipes()
        {
            try
            {
                var username = User.GetUsername();
                var appUser = await _userManager.FindByNameAsync(username);
                var heartedRecipes = await _heartedRecipeService.GetUserHeartedRecipeAsync(appUser);
                return Ok(heartedRecipes);
            }
            catch (ArgumentNullException ex)
            {
                return BadRequest(new { ex.Message });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { ex.Message });
            }
        }
    }
}