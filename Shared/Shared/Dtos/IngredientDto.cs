using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Dtos
{
    public class IngredientDto
    {
        public Guid Id { get; set; }
        public string IngredientName { get; set; } = string.Empty;
        public virtual ICollection<Recept>? Receps { get; set; } = new List<Recept>();
        public virtual Measurements? Measurements { get; set; }
        public Guid? MeasurementsId { get; set; } = Guid.Empty;
        public int Quantity { get; set; } = 0;
    }
}
