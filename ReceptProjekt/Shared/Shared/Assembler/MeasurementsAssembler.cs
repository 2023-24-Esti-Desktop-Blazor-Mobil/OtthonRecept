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
    public class MeasurementsAssambler : Assambler<Measurements, MeasurementsDto>
    {
        public override MeasurementsDto ToDto(Measurements domainEntity)
        {
            return domainEntity.ToDto();
        }

        public override Measurements ToModel(MeasurementsDto dto)
        {
            return dto.ToModel();
        }
    }
}