﻿using System.Xml.Linq;

namespace AdapterLibrary.MovieBroadcasterExample;

public class MovieRegistry
{
    /// <summary>
    /// Get all movies from registry in the XML format.
    /// Let’s say we can't modify the existing functionality
    /// and that movies will always be returned in the XML format.
    /// </summary>
    /// <returns>Movies in the XML format.</returns>
    public XDocument GetAll() => GetAllFromDatabase();

    private XDocument GetAllFromDatabase()
    {
        var xDocument = new XDocument();
        var xMoviesElement = new XElement("Movies");

        var xMovieCollection = GetRegisteredMovies()
            .Select(movie => new XElement(
                "Movie",
                new XAttribute("Name", movie.Name),
                new XAttribute("ReleaseDate", movie.ReleaseDate),
                new XAttribute("Rating", movie.Rating)));

        xMoviesElement.Add(xMovieCollection);
        xDocument.Add(xMoviesElement);

        return xDocument;
    }

    private IEnumerable<Movie> GetRegisteredMovies() =>
        new List<Movie>()
        {
            new()
            {
                Name = "Grave of the Fireflies",
                ReleaseDate = new DateTime(1988, 4, 16),
                Rating = 8.5,
            },
            new()
            {
                Name = "Tae Guk Gi: The Brotherhood of War",
                ReleaseDate = new DateTime(2004, 2, 6),
                Rating = 8.1,
            },
            new()
            {
                Name = "The Man from Earth",
                ReleaseDate = new DateTime(2007, 11, 13),
                Rating = 7.9,
            },
            new()
            {
                Name = "Incendies ",
                ReleaseDate = new DateTime(2010, 1, 12),
                Rating = 8.3,
            },
        };
}
