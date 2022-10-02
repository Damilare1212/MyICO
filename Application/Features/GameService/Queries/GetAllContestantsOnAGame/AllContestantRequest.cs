using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.Features.GameService.Queries.GetAllContestantsOnAGame
{
    public record AllContestantRequest(string GameId) : IRequest<ResponseModel>;
}