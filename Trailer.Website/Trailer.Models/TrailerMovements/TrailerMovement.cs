using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trailers.Models.TrailerMovements
{
    public class TrailerMovement
    {
        public int Id { get; set; }
        public int TrailerId { get; set; }
        public string? NewLocation { get; set; }
        public int Priority { get; set; }
        public bool Complete { get; set; }
    }
}
