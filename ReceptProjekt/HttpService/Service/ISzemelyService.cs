﻿using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpService.Service
{
    public interface ISzemelyService : IBaseService<Szemely>
    {
        public Task<List<Szemely>> SelectAllIncluded();
    }
}
