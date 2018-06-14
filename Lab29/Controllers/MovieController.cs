using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Lab29.Models;

namespace Lab29.Controllers
{
    public class MovieController : ApiController
    {
        [HttpGet] //1.
        public List<Movy> GetAllMovies()
        {
            MoviesEntities ORM = new MoviesEntities();
            return ORM.Movies.ToList();
        }

        [HttpGet] //2.
        public List<Movy> MoviesbyGenre(string Genre)
        {
            MoviesEntities ORM = new MoviesEntities();
            return ORM.Movies.Where(x => x.Genre.Contains(Genre)).ToList();
        }

        [HttpGet] //3.
        public Movy RandomMovie()
        {
            MoviesEntities ORM = new MoviesEntities();
            Random r = new Random();
            List<Movy> MovieList = ORM.Movies.ToList();
            return MovieList[r.Next(0, MovieList.Count)];
             
        }

        [HttpGet] //4.
        public Movy RandomMovieCategory(string genre)
        {
            MoviesEntities ORM = new MoviesEntities();
            Random r = new Random();
            List<Movy> MovieList = ORM.Movies.ToList();
            return ORM.Movies.[r.Next(0, MovieList.Count)];

        }
        [HttpGet]//5.
        public List<Movy>GetRandomMovies(int amount)
        {
            MoviesEntities ORM = new MoviesEntities();
            Random r = new Random();
            List<Movy> MovieList = ORM.Movies.ToList();
            List<Movy> MovieList2 = new List<Movy>();

            for (int i = 0; i < amount; i++)
            {
                int result = r.Next(MovieList.Count());
                MovieList.Add(MovieList2[result]);
                MovieList2.RemoveAt(result);

            }
            return MovieList;
        }

        [HttpGet]//6.
        public List<string> GetAllMovieCategory()
        {
            MoviesEntities ORM = new MoviesEntities();
            return ORM.Movies.Select(x => x.Genre).Distinct().ToList();
        }

        public Movy Info(string title)
        {
            MoviesEntities ORM = new MoviesEntities();

            
        }

        [HttpGet]
        public List<Movy> Keyword(string keyword)
        {
            MoviesEntities ORM = new MoviesEntities();
            return ORM.Movies.Where(x => x.Title.Contains(keyword)).ToList();
        }




    }
}
