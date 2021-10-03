using SpecificationPattern.Domain;
using SpecificationPattern.Specifications;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace SpecificationPattern.Repository
{
    public interface IMovieRepository
    {
        IReadOnlyList<Movie> Find(Specification<Movie> specification);

        IReadOnlyList<Movie> Find(Expression<Func<Movie, bool>> predicate);
    }
}
