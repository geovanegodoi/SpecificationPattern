using System;

namespace SpecificationPattern.Domain
{
    public abstract class Entity
    {
        public Guid Id { get; }
        public DateTime CreatedAt { get; }
        public DateTime UpdatedAt { get; }
    }
}
