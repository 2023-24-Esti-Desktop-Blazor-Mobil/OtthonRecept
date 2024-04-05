using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Dtos
{
    public class CikkDto
    {

        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } =string.Empty;
        public Guid? FeltoltoId { get; set; } = Guid.Empty;
        public DateTime Idopont { get; set; } = DateTime.Now;
        public virtual Szemely? Szemely { get; set; }

    }



}

