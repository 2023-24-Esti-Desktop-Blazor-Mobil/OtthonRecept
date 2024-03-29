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
    public class KepzettsegAssambler : Assambler<Kepzettseg, KepzettsegDto>
    {
        public override KepzettsegDto ToDto(Kepzettseg domainEntity)
        {
            return domainEntity.ToDto();
        }

        public override Kepzettseg ToModel(KepzettsegDto dto)
        {
            return dto.ToModel();
        }
    }
}
