using Shared.Assembler;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HttpService.Service
{
    public class KepzettsegService : BaseService<Kepzettseg, Shared.Dtos.KepzettsegDto>, IKepzettsegService
    {
        public KepzettsegService(IHttpClientFactory? httpClientFactory, KepzettsegAssambler assambler, KepzettsegAssambler kepzettsegAssambler) : base(httpClientFactory, assambler)
        {
        }
    }
}
