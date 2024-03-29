
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
    public class Measurements : IDbEntity<Measurements>
    {
        public Guid Id { get; set; }
        public string IngredientsMeasurements { get; set; } = string.Empty;
        public virtual ICollection<Ingredient>? Ingredients { get; set; } = new List<Ingredient>();
        public bool HasId => Id != Guid.Empty;

        public override string ToString()
        {
            return $"{IngredientsMeasurements}";
        }

    }
}
