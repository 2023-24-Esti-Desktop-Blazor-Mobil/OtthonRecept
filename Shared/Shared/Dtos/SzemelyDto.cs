using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Dtos
{
    public class SzemelyDto
    {
       
            public Guid Id { get; set; }
            public string FirstName { get; set; } = string.Empty;
            public string LastName { get; set; } =string.Empty;
            public int Age { get; set; } = 0;
            public Guid? KepzettsegId { get; set; } = Guid.Empty;
            public virtual Kepzettseg? Kepzettseg { get; set; }
            public ICollection<Cikk>? Cikkek { get; set; } = new List<Cikk>();
            public ICollection<Recept>? Receptek { get; set; } = new List<Recept>();

    }
    }

