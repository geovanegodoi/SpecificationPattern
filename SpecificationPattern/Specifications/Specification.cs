using System;
using System.Linq.Expressions;

namespace SpecificationPattern.Specifications
{
    public abstract class Specification<T> where T : class
    {
        public abstract bool IsSatisfiedBy(T entity);

        public Specification<T> And(Specification<T> specification)
            => new AndSpecification<T>(this, specification);

        public Specification<T> Or(Specification<T> specification)
            => new OrSpecification<T>(this, specification);

        public Specification<T> Not(Specification<T> specification)
            => new NotSpecification<T>(this, specification);
    }
}

