using DesingPattern.Mediator.Results;
using MediatR;

namespace DesingPattern.Mediator.Queries
{
    public class GetAllProductQuery:IRequest<List<GetAllProductQueryResult>>
    {
    }
}
