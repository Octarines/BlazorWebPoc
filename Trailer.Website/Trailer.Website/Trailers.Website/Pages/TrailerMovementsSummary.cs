using Microsoft.AspNetCore.Components;
using Trailers.Models.TrailerMovements;
using Trailers.Services.TrailerMovements;

namespace Trailers.Website.Pages
{
    public partial class TrailerMovementsSummary
    {
        [Inject]
        public ITrailerMovementsService TrailerMovementsService { get; set; }

        public IEnumerable<TrailerMovement> TrailerMovements { get; set; }

        protected override async Task OnInitializedAsync()
        {
            IEnumerable <TrailerMovement> results = await TrailerMovementsService.GetTrailerMovements();
            TrailerMovements = results.OrderBy(x => x.Priority).ToList();
        }
    }
}
