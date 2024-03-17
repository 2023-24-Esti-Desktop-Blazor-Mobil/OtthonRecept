using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
    public class Recept
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int FeltoltoId { get; set; }
        public DateTime Idopont {  get; set; }
        
        //több a többhöz kapcsolat
        public virtual ICollection<Ingredient>? Ingredients { get; set; } = new List<Ingredient>();

        public Recept()
        {
            Name = String.Empty;
            Idopont = DateTime.Now;
            Description = String.Empty;
        }
        public override string ToString()
        {
            return $" Nev: {Name} \t Időpont: {String.Format("{0:yyyy.MM.dd.}", Idopont)} \t Leírás: {Description}";
        }
    }
}
