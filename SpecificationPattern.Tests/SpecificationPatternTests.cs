using FluentAssertions;
using SpecificationPattern.Domain;
using SpecificationPattern.Repository;
using SpecificationPattern.Specifications;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Xunit;

namespace SpecificationPattern.Tests
{
    public class SpecificationPatternTests
    {
        private readonly IMovieRepository _repository;

        public SpecificationPatternTests()
        {
            _repository = new MovieRepositoryStub(
                new List<Movie>
                {
                    new Movie(mpaa: MpaaRating.G    , rating: 1),
                    new Movie(mpaa: MpaaRating.PG13 , rating: 5),
                    new Movie(mpaa: MpaaRating.R    , rating: 10)
                });
        }

        [Fact]
        public void Should_return_only_movies_rated_as_all_ages()
        {
            // Arrange
            var specification = new MpaaRatingAllAgesSpecification();

            // Act
            var output = _repository.Find(specification);

            // Assert
            output.Should().HaveCount(expected: 1);
        }

        [Fact]
        public void Should_return_movies_rated_at_most_as_PG13()
        {
            // Arrange
            var specification = new MpaaRatingAtMostSpecification(MpaaRating.PG13);

            // Act
            var output = _repository.Find(specification);

            // Assert
            output.Should().HaveCount(expected: 2);
        }

        [Fact]
        public void Should_return_movies_rated_as_no_under_17_admitted()
        {
            // Arrange
            var specification = new MpaaRatingNoUnderAgeAdmittedSpecification();

            // Act
            var output = _repository.Find(specification);

            // Assert
            output.Should().BeEmpty();
        }

        [Fact]
        public void Should_return_only_movies_rated_as_X_mpaa_rating()
        {
            // Arrange
            var specification = new MpaaRatingEqualsSpecification(MpaaRating.X);

            // Act
            var output = _repository.Find(specification);

            // Assert
            output.Should().BeEmpty();
        }

        [Fact]
        public void Should_return_only_bad_rated_movies()
        {
            // Arrange
            var specification = new BadRatingSpecification();

            // Act
            var output = _repository.Find(specification);

            // Assert
            output.Should().HaveCount(expected: 1);
        }

        [Fact]
        public void Should_return_only_medium_rated_movies()
        {
            // Arrange
            var specification = new MediumRatingSpecification();

            // Act
            var output = _repository.Find(specification);

            // Assert
            output.Should().HaveCount(expected: 1);
        }

        [Fact]
        public void Should_return_only_good_rated_movies()
        {
            // Arrange
            var specification = new GoodRatingSpecification();

            // Act
            var output = _repository.Find(specification);

            // Assert
            output.Should().HaveCount(expected: 1);
        }

        [Fact]
        public void Should_return_only_good_rated_for_all_ages_movies()
        {
            // Arrange
            var specification = new GoodRatingForAllAgesSpecification();

            // Act
            var output = _repository.Find(specification);

            // Assert
            output.Should().BeEmpty();
        }


        [Fact]
        public void Should_return_only_good_rated_or_all_ages_movies()
        {
            // Arrange
            var specification = new GoodRatingOrAllAgesSpecification();

            // Act
            var output = _repository.Find(specification);

            // Assert
            output.Should().HaveCount(expected: 2);
        }


        [Fact]
        public void Should_return_only_all_ages_and_rated_as_not_bad_movies()
        {
            // Arrange
            var specification = new ForAllAgesAndNotBadRatingSpecification();

            // Act
            var output = _repository.Find(specification);

            // Assert
            output.Should().BeEmpty();
        }
    }
}
