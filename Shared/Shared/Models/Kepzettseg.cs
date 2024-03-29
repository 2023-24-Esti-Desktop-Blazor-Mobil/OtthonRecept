using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
    public class Kepzettseg : IDbEntity<Kepzettseg>
    {
        public Guid Id { get; set; }
        public string SzemelyKepzettseg { get; set; } = string.Empty;
        public virtual ICollection<Szemely>? Szemelyek { get; set; } = new List<Szemely>();
        public bool HasId => Id != Guid.Empty;

        public override string ToString()
        {
            return $"{SzemelyKepzettseg}";
        }

    }
}
