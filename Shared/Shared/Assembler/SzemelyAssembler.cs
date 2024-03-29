using Shared.Dtos;
using Shared.Extensions;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Assembler
{
    public class SzemelyAssambler : Assambler<Szemely, SzemelyDto>
    {
        public override SzemelyDto ToDto(Szemely model)
        {
            return model.ToDto();
        }

        public override Szemely ToModel(SzemelyDto dto)
        {
            return dto.ToModel();
        }
    }
}

