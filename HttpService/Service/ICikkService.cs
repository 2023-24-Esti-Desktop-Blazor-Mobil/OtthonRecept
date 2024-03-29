using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpService.Service
{
    public interface ICikkService : IBaseService<Cikk>
    {
        public Task<List<Cikk>> SelectAllIncluded();
    }
}
