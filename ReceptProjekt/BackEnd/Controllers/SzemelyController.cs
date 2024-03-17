using BackEnd.Repos;
using Microsoft.AspNetCore.Mvc;
using Shared.Dtos;
using Shared.Models;
using Shared.Responses;
using Shared.Extensions;
using Microsoft.EntityFrameworkCore;
using Shared.Parameters;
using Shared.Assembler;

namespace BackEnd.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SzemelyController : BaseController<Szemely, SzemelyDto>
    {
        private readonly ISzemelyRepo _szemelyRepo;
        public SzemelyController(SzemelyAssambler assembler, ISzemelyRepo repo) : base(assembler, repo)
        {
            _szemelyRepo = repo;
        }

        [HttpGet("included")]
        public async Task<IActionResult> SelectAllIncludedAsync()
        {
            List<Szemely>? szemelys = new();
            if (_repo != null)
            {
                try
                {
                    szemelys = await _szemelyRepo.SelectAllIncluded().ToListAsync();
                    return Ok(szemelys.Select(entity => _assambler.ToDto(entity)));
                }
                catch (Exception ex)
                {
                }
            }
            return BadRequest("Az adatok elérhetetlenek!");
        }
        [HttpGet("ByCikk")]
        public async Task<IActionResult> SelectAllByCikkAsync()
        {
            List<Szemely>? szemelys = new();
            if (_repo != null)
            {
                try
                {
                    szemelys = await _szemelyRepo.SelectAllByCikk().ToListAsync();
                    return Ok(szemelys.Select(entity => _assambler.ToDto(entity)));
                }
                catch (Exception ex)
                {
                }
            }
            return BadRequest("Az adatok elérhetetlenek!");
        }


    }
}
