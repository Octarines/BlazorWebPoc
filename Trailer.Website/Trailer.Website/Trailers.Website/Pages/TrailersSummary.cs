using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Trailers.Models;
using Trailers.Models.TrailerMovements;
using Trailers.Services;
using Trailers.Services.TrailerMovements;

namespace Trailers.Website.Pages
{
    public partial class TrailersSummary
    {
        [Inject]
        public ITrailersService TrailersService { get;set; }

        [Inject]
        public ITrailerMovementsService TrailerMovementsService { get; set; }

        public IEnumerable<Trailer> Trailers { get; set; }

        public Trailer SelectedTrailer { get; set; }

        public string NewLocation { get; set; }
        public int MovePriority { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Trailers = await TrailersService.GetTrailers();
        }

        public async void MoveSelectedTrailer(MouseEventArgs e)
        {
            int movementId = await TrailerMovementsService.CreateTrailerMovement(new TrailerMovement()
            {
                TrailerId = SelectedTrailer.Id,
                NewLocation = NewLocation,
                Priority = MovePriority
            });

            SelectedTrailer = default;
        }
    }
}
