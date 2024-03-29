using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
    public class Recept : IDbEntity<Recept>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid? FeltoltoId { get; set; }
        public virtual Szemely? Szemely { get; set; }

        public DateTime Idopont {  get; set; }
        public bool HasId => Id != Guid.Empty;

        public Guid? IngredientId { get; set; }
        public virtual Ingredient? Ingredient { get; set; }


        public Recept()
        {
            Id = Guid.Empty;
            Name = String.Empty;
            Description = String.Empty;
            FeltoltoId = Guid.Empty;
            IngredientId = Guid.Empty;
            Idopont = DateTime.Now;
        }
        public Recept(string name, string description, Guid feltoltoId, Guid ingredientId, DateTime idopont)
        {
            Id = Guid.NewGuid();
            Name = name;
            Description = description;
            FeltoltoId = feltoltoId;
            IngredientId = ingredientId;
            Idopont = idopont;

        }

        public override string ToString()
        {
            return $" Nev: {Name} \t Időpont: {String.Format("{0:yyyy.MM.dd.}", Idopont)} \t Leírás: {Description}";
        }
    }
}
