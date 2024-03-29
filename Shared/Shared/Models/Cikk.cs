using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{

    public class Cikk : IDbEntity<Cikk>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid? FeltoltoId { get; set; } 
        public virtual Szemely? Szemely { get; set; }
        public DateTime Idopont { get; set; }
        public bool HasId => Id != Guid.Empty;
       
        public Cikk()
        {
            Id = Guid.Empty;
            Name = string.Empty;
            Description = string.Empty;
            FeltoltoId = Guid.Empty;
            Idopont=DateTime.Now;
        }
        public Cikk(string name, string description, Guid feltoltoId, DateTime idopont)
        {
            Id=Guid.NewGuid();
            Name = name;
            Description = description;
            FeltoltoId = feltoltoId;
            Idopont = idopont;
        }

        public override string ToString()
        {
            return $" Nev: {Name} \t Időpont: {String.Format("{0:yyyy.MM.dd.}", Idopont)}  \t Leírás: {Description} ";
        }
    }
}

