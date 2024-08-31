using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DDD.Specifications.Definitions.DomainSpecific;
using DDD.Specifications.Entities;
using DDD.Specifications.Repository;
using FluentAssertions;

namespace DesignPatternsExample.UnitTest.Specification
{
    public class Specification_SelectionUnitTest
    {
        [Fact]
        public void WhenISelectDataByWomanSpecification_ResultShouldNotContainPersonWithMaleGender()
        {
            var womenSpec = new WomanSpecification();
            var people = new PersonRepository()
                .GetPeople()
                .Where(p => womenSpec.IsSatisfiedBy(p))
                .ToList();

            people.Should().NotContain(p => p.Gender == Gender.Male);
        }

        [Fact]
        public void WhenISelectDataBySonSpecification_ResultShouldNotContainPersonWithFemaleGenderOrAgeGreaterThanSeventeen()
        {
            var sonSpecification = new SonSpecification();
            var people = new PersonRepository()
                .GetPeople()
                .Where(p => sonSpecification.IsSatisfiedBy(p))
                .ToList();

            people.Should().AllSatisfy(p => p.Age.Should().BeLessThan(18));
            people.Should().AllSatisfy(p => p.Gender.Should().Be(Gender.Male));
        }
    }
}
