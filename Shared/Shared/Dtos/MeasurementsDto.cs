using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Dtos
{
    public class MeasurementsDto
    {
        public Guid Id { get; set; }
        public string IngredientsMeasurements { get; set; } = string.Empty;
        public virtual ICollection<Ingredient>? Ingredients { get; set; } = new List<Ingredient>();
    }
}
