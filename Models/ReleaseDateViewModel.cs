using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MvcMovie.Models;

public class ReleaseDateViewModel
{
    public List<Movie>? Movies { get; set; }
    public SelectList? DateTime { get; set; }
    public string? ReleaseDate { get; set; }
    public string? SearchString { get; set; }
    public SelectList DateTimeOptions { get; internal set; }
}