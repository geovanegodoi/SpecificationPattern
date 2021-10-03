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
    }

    public class AndSpecification<T> : Specification<T> where T : class
    {
        private readonly Specification<T> _left;
        private readonly Specification<T> _right;

        public AndSpecification(Specification<T> left, Specification<T> right)
        {
            _left  = left;
            _right = right;
        }

        public override bool IsSatisfiedBy(T entity)
            => _left.IsSatisfiedBy(entity)
            && _right.IsSatisfiedBy(entity);
    }

    public class OrSpecification<T> : Specification<T> where T : class
    {
        private readonly Specification<T> _left;
        private readonly Specification<T> _right;

        public OrSpecification(Specification<T> left, Specification<T> right)
        {
            _left  = left;
            _right = right;            
        }

        public override bool IsSatisfiedBy(T entity)
            => _left.IsSatisfiedBy(entity)
            || _right.IsSatisfiedBy(entity);
    }
}

