using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using Trailers.Models.TrailerMovements;

namespace Trailers.Services.TrailerMovements
{
    public class TrailerMovementsService : ITrailerMovementsService
    {
        private const string ServiceUrl = "https://localhost:7159/movement";

        private readonly HttpClient _httpClient;

        private List<TrailerMovement> _trailerMovements;

        public TrailerMovementsService(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _trailerMovements = new List<TrailerMovement>();
        }

        public async Task<int> CreateTrailerMovement(TrailerMovement trailerMovement)
        {
            int results = await _httpClient.GetFromJsonAsync<int>($"{ServiceUrl}/add/{trailerMovement.TrailerId}/{trailerMovement.NewLocation}/{trailerMovement.Priority}");
            return results;
        }

        public async Task DeleteTrailerMovement(int trailerMovementId)
        {
            await _httpClient.DeleteAsync($"{ServiceUrl}/delete/{trailerMovementId}");
        }

        public async Task ReprioritiseTrailerMovement(IEnumerable<TrailerMovement> trailerMovements)
        {
            await _httpClient.PostAsJsonAsync<IEnumerable<TrailerMovement>>($"{ServiceUrl}/priorities", trailerMovements);
        }

        public async Task<IEnumerable<TrailerMovement>> GetTrailerMovements()
        {
            IEnumerable<TrailerMovement> results = await _httpClient.GetFromJsonAsync<IEnumerable<TrailerMovement>>($"{ServiceUrl}");
            return results;
        }
    }
}
