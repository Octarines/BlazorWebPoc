using System.Net.Http.Json;
using Trailers.Models;

namespace Trailers.Services
{
    public class TrailersService: ITrailersService
    {
        private readonly HttpClient _httpClient;

        public TrailersService(HttpClient httpClient)
        {
            _httpClient = httpClient;

            
            //_trailers = new List<Trailer>()
            //{
            //    new Trailer()
            //    {
            //        Id = 1,
            //        Name = "Trailer 1",
            //        Location = "Yard"
            //    }
            //};
        }

        public async Task<IEnumerable<Trailer>> GetTrailers()
        { 
            return await _httpClient.GetFromJsonAsync<IEnumerable<Trailer>>("https://localhost:7159/trailers"); ;
        }
    }
}