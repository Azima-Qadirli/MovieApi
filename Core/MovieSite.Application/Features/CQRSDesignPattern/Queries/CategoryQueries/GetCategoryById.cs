namespace MovieSite.Application.Features.CQRSDesignPattern.Queries.CategoryQueries
{
    public class GetCategoryById
    {
        public GetCategoryById(int categoryId)
        {
            CategoryId = categoryId;
        }

        public int CategoryId { get; set; }
    }
}
