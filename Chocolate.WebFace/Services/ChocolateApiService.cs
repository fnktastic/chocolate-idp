using Chocolate.Domain.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Chocolate.WebFace.Services
{
    public class ChocolateApiService : IChocolateApiService
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public ChocolateApiService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IEnumerable<ChocolateDto>> GetAllAsync()
        {
            var httpClient = _httpClientFactory.CreateClient("ApiClient");

            var request = new HttpRequestMessage(
                HttpMethod.Get,
                "/api/chocolate/getall");

            var response = await httpClient.SendAsync(
                request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false);

            if (response.IsSuccessStatusCode)
            {
                using (var responseStream = await response.Content.ReadAsStreamAsync())
                {
                    return await JsonSerializer
                        .DeserializeAsync<List<ChocolateDto>>(responseStream);
                }
            }
            else if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized ||
                    response.StatusCode == System.Net.HttpStatusCode.Forbidden)
            {
                return null;
            }

            throw new Exception("Problem accessing the API");
        }
    }
}
