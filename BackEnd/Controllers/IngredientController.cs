
using BackEnd.Repos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Shared.Assembler;
using Shared.Dtos;
using Shared.Models;

namespace BackEnd.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class IngredientController : BaseController<Ingredient, IngredientDto>
    {
        private readonly IIngredientRepo _ingredientRepo;
        public IngredientController(IngredientAssambler assembler, IIngredientRepo repo) : base(assembler, repo)
        {
            _ingredientRepo = repo;
        }

        [HttpGet("included")]
        public async Task<IActionResult> SelectAllIncludedAsync()
        {
            List<Ingredient>? ingredients = new();
            if (_repo != null)
            {
                try
                {
                    ingredients = await _ingredientRepo.SelectAllIncluded().ToListAsync();
                    return Ok(ingredients.Select(entity => _assambler.ToDto(entity)));
                }
                catch (Exception ex)
                {
                }
            }
            return BadRequest("Az adatok elérhetetlenek!");
        }
    }
}
