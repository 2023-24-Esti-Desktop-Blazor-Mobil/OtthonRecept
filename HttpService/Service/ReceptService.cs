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
    public class ReceptService : BaseService<Recept, ReceptDto>, IReceptService
    {
        public ReceptService(IHttpClientFactory? httpClientFactory, ReceptAssambler receptAssambler) : base(httpClientFactory, receptAssambler)
        {
        }
        public async Task<List<Recept>> SelectAllIncluded()
        {
            if (_httpClient is not null)
            {
                try
                {

                    List<ReceptDto>? resultDto = await _httpClient.GetFromJsonAsync<List<ReceptDto>>($"api/Recept/included");
                    if (resultDto is not null)
                    {
                        List<Recept> result = resultDto.Select(recept => _assambler.ToModel(recept)).ToList();
                        return result;
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                }
            }
            return new List<Recept>();
        }

    }
}
