using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trailers.Models.TrailerMovements;

namespace Trailers.Services.TrailerMovements
{
    public interface ITrailerMovementsService
    {
        public Task<IEnumerable<TrailerMovement>> GetTrailerMovements();
        public Task<int> CreateTrailerMovement(TrailerMovement trailerMovement);
        public Task DeleteTrailerMovement(int trailerMovementId);
        public Task ReprioritiseTrailerMovement(IEnumerable<TrailerMovement> trailerMovements);
    }
}
