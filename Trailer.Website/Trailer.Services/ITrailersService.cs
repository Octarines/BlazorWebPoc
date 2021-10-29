using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trailers.Models;

namespace Trailers.Services
{
    public interface ITrailersService
    {
        public Task<IEnumerable<Trailer>> GetTrailers();
    }
}
