using SpecificationPattern.Domain;

namespace SpecificationPattern.Specifications
{
    public class GoodRatingOrAllAgesSpecification : Specification<Movie>
    {
        public override bool IsSatisfiedBy(Movie entity)
            => new GoodRatingSpecification()
                .Or(new MpaaRatingAllAgesSpecification())
                    .IsSatisfiedBy(entity);
    }
}
