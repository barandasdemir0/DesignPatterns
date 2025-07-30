namespace DesingPattern.CQRS.CQRSPattern.Queries
{
    public class GetProductByIDQuery
    {
        public GetProductByIDQuery(int ıd)
        {
            Id = ıd;
        }

        public int Id { get; set; }
    }
}
