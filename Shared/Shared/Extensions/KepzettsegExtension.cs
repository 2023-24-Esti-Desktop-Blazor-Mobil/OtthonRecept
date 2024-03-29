using Shared.Dtos;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Extensions
{
    public static class KepzettsegExtension
    {
        public static KepzettsegDto ToDto(this Kepzettseg kepzettseg)
        {
            return new KepzettsegDto
            {
                Id = kepzettseg.Id,
                SzemelyKepzettseg = kepzettseg.SzemelyKepzettseg,
                Szemelyek = kepzettseg.Szemelyek,
            };
        }

        public static Kepzettseg ToModel(this KepzettsegDto model)
        {
            return new Kepzettseg
            {
                Id = model.Id,
                SzemelyKepzettseg = model.SzemelyKepzettseg,
                Szemelyek = model.Szemelyek,
            };
        }
    }
}
