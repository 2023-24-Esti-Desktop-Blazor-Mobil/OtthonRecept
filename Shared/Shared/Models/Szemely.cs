using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
    public class Szemely : IDbEntity<Szemely>
    {
        
        public Guid Id {  get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Guid? KepzettsegId { get; set; }
        public virtual Kepzettseg? Kepzettseg { get; set; }
        public bool HasId => Id != Guid.Empty;
        public virtual ICollection<Cikk>? Cikks { get; set; } = new List<Cikk>();

        public virtual ICollection<Recept>? Receptek { get; set; } = new List<Recept>();

        public Szemely(string firstName, string lastName, int age, Guid kepzettsegId)
        {
            Id = Guid.NewGuid();
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            KepzettsegId = kepzettsegId;


        }
        public Szemely() {
            Id = Guid.Empty;
            FirstName = string.Empty;
            LastName = string.Empty;
            Age = 0;
            KepzettsegId = Guid.Empty;

        }
        public override string ToString()
        {
            
            return $"{FirstName} {LastName}";
        }
    }
}

