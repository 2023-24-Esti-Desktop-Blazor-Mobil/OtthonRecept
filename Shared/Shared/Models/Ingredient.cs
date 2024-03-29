using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
    public class Ingredient : IDbEntity<Ingredient>
    {
        public Guid Id { get; set; }
        public int Quantity { get; set; }
        public string IngredientName { get; set; } = string.Empty;
        public Guid? MeasurementsId { get; set; }
        public virtual Measurements? Measurements { get; set; }
        public virtual ICollection<Recept>? Receps { get; set; } = new List<Recept>();
        public bool HasId => Id != Guid.Empty;

        public Ingredient(string ingredientName, Guid measurementsId, int quantity)
        {
            Id = Guid.NewGuid();
            IngredientName = ingredientName;
            MeasurementsId = measurementsId;
            Quantity = quantity;
        }
        public Ingredient()
        {
            Id = Guid.Empty;
            Quantity = 0;
            IngredientName = string.Empty;
            MeasurementsId = Guid.Empty;

        }




        public override string ToString()
        {
            return $"{Quantity}{Measurements}{IngredientName}";
        }

    }
}
