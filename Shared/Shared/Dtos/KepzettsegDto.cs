using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Dtos
{
    public class KepzettsegDto
    {
        public Guid Id { get; set; }
        public string SzemelyKepzettseg { get; set; } = string.Empty;
        public ICollection<Szemely>? Szemelyek { get; set; } = new List<Szemely>();
    }
}
