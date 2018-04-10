using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DavidNaputi.MovieLib.Data
{
    public static class MovieDatabaseExtensions
    {
        /// <summary>Seeds the database.</summary>
        /// <param name="source">The source.</param>
        public static void Seed( this IMovieDatabase source )
        {
            var message = "";
            source.Add(new Movie() {
                Id = 1,
                Title = "Example Title Seed",
                Description = "Example Description Seed",
                Length = 100,
                IsOwned = true }, out message);
            }
    }
}
