using System;
using System.Collections.Generic;

namespace DavidNaputi.MovieLib.Data.Memory
{

    /// <summary>Provides an in-memory movie database.</summary>
    public class MemoryMovieDatabase : MovieDatabase
    {
        ///// <summary>Initializes an instance of the <see cref="MemoryMovieDatabase"/> class.</summary>
        //public MemoryMovieDatabase()
        //{
        //    //Array version
        //    //var prods = new Movie[]
        //    //var prods = new []
        //    //    {
        //    //        new Movie(),
        //    //        new Movie()
        //    //    };
    
        //    //_movies = new Movie[25];
        //    _movies = new List<Movie>() 
        //    {
        //        new Movie() { Id = _nextId++, Name = "iPhone X",
        //                        IsDiscontinued = true, Price = 1500, },
        //        new Movie() { Id = _nextId++, Name = "Windows Phone",
        //                        IsDiscontinued = true, Price = 15, },
        //        new Movie() { Id = _nextId++, Name = "Samsung S8",
        //                        IsDiscontinued = false, Price = 800 }
        //    };
    
        //    //var movie = new Movie() {
        //    //    Id = _nextId++,
        //    //    Name = "iPhone X",
        //    //    IsDiscontinued = true,
        //    //    Price = 1500,
        //    //};
        //    //_movies.Add(movie);
    
        //    //movie = new Movie() {
        //    //    Id = _nextId++,
        //    //    Name = "Windows Phone",
        //    //    IsDiscontinued = true,
        //    //    Price = 15,
        //    //};
        //    //_movies.Add(movie);
    
        //    //movie = new Movie {
        //    //    Id = _nextId++,
        //    //    Name = "Samsung S8",
        //    //    IsDiscontinued = false,
        //    //    Price = 800
        //    //};
        //    //_movies.Add(movie);
        //}
    
        protected override Movie AddCore( Movie movie )
        {
            // Clone the object
            movie.Id = _nextId++;
            _movies.Add(Clone(movie));
    
            // Return a copy
            return movie;
        }
    
        protected override Movie GetCore( int id )
        {
            //for (var index = 0; index < _movies.Length; ++index)
            foreach (var movie in _movies)
            {
                if (movie.Id == id)
                    return movie;
            };
    
            return null;
        }
    
        protected override IEnumerable<Movie> GetAllCore()
        {
            //Iterator syntax
            foreach (var movie in _movies)
            {
                if (movie != null)
                    yield return Clone(movie);
            };
        }

        protected override void RemoveCore( int id )
        {
            var existing = GetCore(id);
            if (existing != null)
                _movies.Remove(existing);
        }
    
        protected override Movie UpdateCore( Movie movie )
        {
            var existing = GetCore(movie.Id);
    
            // Clone the object
            //_movies[existingIndex] = Clone(movie);
            Copy(existing, movie);
    
            //Return a copy
            return movie;
        }
    
        protected override Movie GetMovieByTitleCore( string title )
        {
            foreach (var movie in _movies)
            {
                //movie.Name.CompareTo
                if (String.Compare(movie.Title, title, true) == 0)
                    return movie;
            };
    
            return null;
        }
    
        #region Private Members
    
        //Clone a movie
        private Movie Clone( Movie item )
        {
            var newMovie = new Movie();
            Copy(newMovie, item);
    
            return newMovie;
        }
    
        //Copy a movie from one object to another
        private void Copy( Movie target, Movie source )
        {
            target.Id = source.Id;
            target.Title = source.Title;
            target.Description = source.Description;
            target.Length = source.Length;
            target.IsOwned = source.IsOwned;
        }
    
        //private int FindEmptyMovieIndex()
        //{
        //    for (var index = 0; index < _movies.Length; ++index)
        //    {
        //        if (_movies[index] == null)
        //            return index;
        //    };
    
        //    return -1;
        //}
    
        //Find a movie by its ID
    
        private readonly List<Movie> _movies = new List<Movie>();
        private int _nextId = 1;
    
        #endregion
    }
}
