using Shared.Dtos;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Extensions
{
    public static class CikkExtension
    {
        public static CikkDto ToDto(this Cikk cikk)
        {
            return new CikkDto
            {
                Id = cikk.Id,
                Name = cikk.Name,
                Description = cikk.Description,
                Szemely = cikk.Szemely,
                FeltoltoId = cikk.FeltoltoId,
                Idopont = cikk.Idopont,
            };
        }

        public static Cikk ToModel(this CikkDto cikkdto)
        {
            return new Cikk
            {
                Id = cikkdto.Id,
                Name = cikkdto.Name,
                Description = cikkdto.Description,
                Szemely = cikkdto.Szemely,
                FeltoltoId = cikkdto.FeltoltoId,
                Idopont = cikkdto.Idopont,
            };
        }

    }
}
