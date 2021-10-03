using SpecificationPattern.Domain;
using System;
using System.Linq.Expressions;

namespace SpecificationPattern.Specifications
{
    public class GoodRatingForAllAgesSpecification : Specification<Movie>
    {
        public override bool IsSatisfiedBy(Movie entity)
            => new GoodRatingSpecification()
                .And(new MpaaRatingAllAgesSpecification())
                    .IsSatisfiedBy(entity);
    }

    public class GoodRatingOrAllAgesSpecification : Specification<Movie>
    {
        public override bool IsSatisfiedBy(Movie entity)
            => new GoodRatingSpecification()
                .Or(new MpaaRatingAllAgesSpecification())
                    .IsSatisfiedBy(entity);
    }
}
