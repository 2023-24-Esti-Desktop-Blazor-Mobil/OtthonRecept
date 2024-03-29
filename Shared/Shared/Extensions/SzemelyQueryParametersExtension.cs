using Shared.Dtos;
using Shared.Parameters;

namespace Shared.Extensions
{
    public static class SzemelyQueryParametersExtension
    {
        public static SzemelyQueryParametersDto ToDto(this SzemelyQueryParameters parameters)
        {
            return new SzemelyQueryParametersDto
            {
                MaxAge = parameters.MaxAge,
                MinAge = parameters.MinAge,
                FirstName = parameters.FirstName
            };
        }

        public static SzemelyQueryParameters ToSzemelyQueryParameters(this SzemelyQueryParametersDto parameters)
        {
            return new SzemelyQueryParameters
            {
                MaxAge = parameters.MaxAge,
                MinAge = parameters.MinAge,
                FirstName = parameters.FirstName
            };


        }
    }
}
