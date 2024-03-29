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
    public class IngredientService : BaseService<Ingredient, IngredientDto>, IIngredientService
    {
        public IngredientService(IHttpClientFactory? httpClientFactory, IngredientAssambler ingredientAssambler) : base(httpClientFactory, ingredientAssambler)
        {
        }
        public async Task<List<Ingredient>> SelectAllIncluded()
        {
            if (_httpClient is not null)
            {
                try
                {

                    List<IngredientDto>? resultDto = await _httpClient.GetFromJsonAsync<List<IngredientDto>>($"api/Ingredient/included");
                    if (resultDto is not null)
                    {
                        List<Ingredient> result = resultDto.Select(ingredient => _assambler.ToModel(ingredient)).ToList();
                        return result;
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                }
            }
            return new List<Ingredient>();
        }

    }
}

