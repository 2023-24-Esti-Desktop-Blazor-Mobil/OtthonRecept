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
    public class ReceptController : BaseController<Recept, ReceptDto>
    {
        private readonly IReceptRepo _receptRepo;
        public ReceptController(ReceptAssambler assembler, IReceptRepo repo) : base(assembler, repo)
        {
            _receptRepo = repo;
        }

        [HttpGet("included")]
        public async Task<IActionResult> SelectAllIncludedAsync()
        {
            List<Recept>? receptek = new();
            if (_repo != null)
            {
                try
                {
                    receptek = await _receptRepo.SelectAllIncluded().ToListAsync();
                    return Ok(receptek.Select(entity => _assambler.ToDto(entity)));
                }
                catch (Exception ex)
                {
                }
            }
            return BadRequest("Az adatok elérhetetlenek!");
        }
        

    }
}
