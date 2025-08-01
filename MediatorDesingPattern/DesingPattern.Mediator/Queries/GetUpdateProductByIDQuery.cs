using DesingPattern.Mediator.Results;
using MediatR;

namespace DesingPattern.Mediator.Queries
{
    public class GetUpdateProductByIDQuery:IRequest<UpdateProductByIDQueryResult>
    {
        public int Id { get; set; }

        public GetUpdateProductByIDQuery(int id)
        {
            Id = id;
        }
    }
}
