using Microsoft.AspNetCore.Mvc.Rendering;

namespace MvcMovie.Models;
public class MovieGenreViewModel {
    public List<Movie> Movies { get; set; } = default!;
    public SelectList Genres { get; set; } = default!;
    public SelectList Ratings { get; set; } = default!;
    public string MovieGenre { get; set; } = default!;
    public string MovieRating { get; set; } = default!;
    public string SearchString { get; set; } = default!;    

}