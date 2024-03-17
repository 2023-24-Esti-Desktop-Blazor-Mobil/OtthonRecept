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
    public class KepzettsegController : BaseController<Kepzettseg, KepzettsegDto>
    {
        private readonly IKepzettsegRepo _kepzettsegRepo;
        public KepzettsegController(KepzettsegAssambler assembler, IKepzettsegRepo repo) : base(assembler, repo)
        {
            _kepzettsegRepo = repo;
        }

        [HttpGet("included")]
        public async Task<IActionResult> SelectAllIncludedAsync()
        {
            List<Kepzettseg>? kepzettsegek = new();
            if (_repo != null)
            {
                try
                {
                    kepzettsegek = await _kepzettsegRepo.SelectAllIncluded().ToListAsync();
                    return Ok(kepzettsegek.Select(entity => _assambler.ToDto(entity)));
                }
                catch (Exception ex)
                {
                }
            }
            return BadRequest("Az adatok elérhetetlenek!");
        }
    }
}
