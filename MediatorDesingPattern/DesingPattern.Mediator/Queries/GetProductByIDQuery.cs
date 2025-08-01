using DesingPattern.Mediator.Results;
using MediatR;

namespace DesingPattern.Mediator.Queries
{
    public class GetProductByIDQuery:IRequest<GetProductByIDQueryResult>
    {
        public GetProductByIDQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
