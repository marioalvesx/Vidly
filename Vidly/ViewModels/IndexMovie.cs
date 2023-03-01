using Vidly.Models;

namespace Vidly.ViewModels
{
    public class IndexMovie
    {
        public Movie Movie { get; set; }
        public IEnumerable<Movie> Movies { get; set; }
    }
}
