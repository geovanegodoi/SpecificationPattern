using SpecificationPattern.Domain;
using SpecificationPattern.Repository;
using SpecificationPattern.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace SpecificationPattern.Tests
{
    public class MovieRepositoryStub : IMovieRepository
    {
        private readonly List<Movie> _movies;

        public MovieRepositoryStub(IEnumerable<Movie> movies)
        {
            _movies = new List<Movie>(movies);
        }

        public IReadOnlyList<Movie> Find(Specification<Movie> specification)
            => _movies.Where(m => specification.IsSatisfiedBy(m)).ToList();

        public IReadOnlyList<Movie> Find(Expression<Func<Movie, bool>> predicate)
            => _movies.Where(predicate.Compile()).ToList();
    }
}
