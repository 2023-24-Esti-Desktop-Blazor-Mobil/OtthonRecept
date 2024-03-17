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
    public class IngredientAssambler : Assambler<Ingredient, IngredientDto>
    {
        public override IngredientDto ToDto(Ingredient domainEntity)
        {
            return domainEntity.ToDto();
        }

        public override Ingredient ToModel(IngredientDto dto)
        {
            return dto.ToModel();
        }
    }
}
