using Shared.Dtos;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Extensions
{
        public static class MeasurementExtension
        {
            public static MeasurementsDto ToDto(this Measurements measurement)
            {
                return new MeasurementsDto
                {
                    Id = measurement.Id,
                    IngredientsMeasurements = measurement.IngredientsMeasurements,
                    Ingredients = measurement.Ingredients,
                };
            }

            public static Measurements ToModel(this MeasurementsDto model)
            {
                return new Measurements
                {
                    Id = model.Id,
                    IngredientsMeasurements = model.IngredientsMeasurements,
                    Ingredients = model.Ingredients,
                };
            }
        }
    }

