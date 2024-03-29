using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Json;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Shared.Models;
using Shared.Dtos;
using Shared.Assembler;

namespace HttpService.Service
{
    public class SzemelyService : BaseService<Szemely, SzemelyDto>, ISzemelyService
    {
        public SzemelyService(IHttpClientFactory? httpClientFactory, SzemelyAssambler szemelyAssambler) : base(httpClientFactory, szemelyAssambler)
        {
        }
        public async Task<List<Szemely>> SelectAllIncluded()
        {
            if (_httpClient is not null)
            {
                try
                {

                    List<SzemelyDto>? resultDto = await _httpClient.GetFromJsonAsync<List<SzemelyDto>>($"api/Szemely/included");
                    if (resultDto is not null)
                    {
                        List<Szemely> result = resultDto.Select(szemely => _assambler.ToModel(szemely)).ToList();
                        return result;
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                }
            }
            return new List<Szemely>();
        }
              
    }
}
