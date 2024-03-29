using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Dtos
{
    public class ReceptDto
    {

        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime Idopont { get; set; }

        public Guid? FeltoltoId { get; set; } = Guid.Empty;
        public virtual Szemely? Szemely { get; set; }

        //public Guid? IngredientId { get; set; } = Guid.Empty;
        //public virtual Ingredient? Ingredient { get; set; }
       
    }
}


