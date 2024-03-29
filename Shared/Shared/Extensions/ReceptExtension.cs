using Shared.Dtos;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Extensions
{
    public static class ReceptExtension
    {
        public static ReceptDto ToDto(this Recept recept)
        {
            return new ReceptDto
            {
                Id = recept.Id,
                Name = recept.Name,
                Description = recept.Description,
                FeltoltoId= recept.FeltoltoId,
                IngredientId = recept.IngredientId,
                Ingredient = recept.Ingredient,
                Szemely = recept.Szemely,
            };
        }

        public static Recept ToModel(this ReceptDto receptdto)
        {
            return new Recept
            {
                Id = receptdto.Id,
                Name = receptdto.Name,
                Description = receptdto.Description,
                FeltoltoId = receptdto.FeltoltoId,
                IngredientId = receptdto.IngredientId,
                Ingredient = receptdto.Ingredient,
                Szemely=receptdto.Szemely,

            };
        }

    }
}
