using Shared.Assembler;
using Shared.Dtos;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace HttpService.Service
{
    public class CikkService : BaseService<Cikk, CikkDto>, ICikkService
    {
        public CikkService(IHttpClientFactory? httpClientFactory, CikkAssambler cikkAssambler) : base(httpClientFactory, cikkAssambler)
        {
        }
        public async Task<List<Cikk>> SelectAllIncluded()
        {
            if (_httpClient is not null)
            {
                try
                {

                    List<CikkDto>? resultDto = await _httpClient.GetFromJsonAsync<List<CikkDto>>($"api/Cikk/included");
                    if (resultDto is not null)
                    {
                        List<Cikk> result = resultDto.Select(cikk => _assambler.ToModel(cikk)).ToList();
                        return result;
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                }
            }
            return new List<Cikk>();
        }

    }
}
