using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Assembler
{
    public abstract class Assambler<Tmodel, TDto>
    {
        public abstract Tmodel ToModel(TDto dto);
        public abstract TDto ToDto(Tmodel domainEntity);
    }
}
