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
    public class ReceptAssambler : Assambler<Recept, ReceptDto>
    {
        public override ReceptDto ToDto(Recept model)
        {
            return model.ToDto();
        }

        public override Recept ToModel(ReceptDto dto)
        {
            return dto.ToModel();
        }
    }
}
