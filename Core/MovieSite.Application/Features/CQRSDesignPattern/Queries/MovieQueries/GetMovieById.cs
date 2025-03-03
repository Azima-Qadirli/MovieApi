namespace MovieSite.Application.Features.CQRSDesignPattern.Queries.MovieQueries
{
    public class GetMovieById
    {
        public GetMovieById(int movieId)
        {
            MovieId = movieId;
        }

        public int MovieId { get; set; }
    }
}
