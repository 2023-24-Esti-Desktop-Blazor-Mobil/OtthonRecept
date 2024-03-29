using Shared.Dtos;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Extensions
{
    public static class IngredientExtension
    {
        public static IngredientDto ToDto(this Ingredient ingredient)
        {
            return new IngredientDto
            {
                Id = ingredient.Id,
                IngredientName = ingredient.IngredientName,
                MeasurementsId = ingredient.MeasurementsId,
                Measurements = ingredient.Measurements,
                Quantity = ingredient.Quantity,

            };
        }

        public static Ingredient ToModel(this IngredientDto model)
        {
            return new Ingredient
            {
                Id = model.Id,
                IngredientName = model.IngredientName,
                MeasurementsId = model.MeasurementsId,
                Measurements = model.Measurements,
                Quantity=model.Quantity,
            };
        }
    }
}
