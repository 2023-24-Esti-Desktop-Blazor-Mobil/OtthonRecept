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
    public class CikkController : BaseController<Cikk, CikkDto>
    {
        private readonly ICikkRepo _cikkRepo;
        public CikkController(CikkAssambler assembler, ICikkRepo repo) : base(assembler, repo)
        {
            _cikkRepo = repo;
        }

        [HttpGet("included")]
        public async Task<IActionResult> SelectAllIncludedAsync()
        {
            List<Cikk>? cikks = new();
            if (_repo != null)
            {
                try
                {
                    cikks = await _cikkRepo.SelectAllIncluded().ToListAsync();
                    return Ok(cikks.Select(entity => _assambler.ToDto(entity)));
                }
                catch (Exception ex)
                {
                }
            }
            return BadRequest("Az adatok elérhetetlenek!");
        }
    }
}
