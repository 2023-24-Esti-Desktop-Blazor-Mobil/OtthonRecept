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
    public class CikkAssambler : Assambler<Cikk, CikkDto>
    {
        public override CikkDto ToDto(Cikk model)
        {
            return model.ToDto();
        }

        public override Cikk ToModel(CikkDto dto)
        {
            return dto.ToModel();
        }
    }
}
