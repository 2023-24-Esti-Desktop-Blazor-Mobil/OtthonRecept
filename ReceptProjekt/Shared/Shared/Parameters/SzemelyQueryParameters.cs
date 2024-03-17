using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Parameters
{
    public class SzemelyQueryParameters
    {
        public uint MinAge { get; set; }
        public uint MaxAge { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public bool ValidAgeRange => MaxAge > MinAge;
    }
}
