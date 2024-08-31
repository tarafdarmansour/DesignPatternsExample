using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DDD.Specifications.Definitions.DomainSpecific;
using DDD.Specifications.Entities;
using FluentAssertions;

namespace DesignPatternsExample.UnitTest.Specification
{
    public class Specification_ValidationUnitTest
    {
        [Fact]
        public void WhenICreatePersonWithAge50_AdultSpecificationShouldSatisfyIt()
        {
            var person = new Person()
            {
                Gender = Gender.Male,
                DateOfBirth = DateTime.Now.AddYears(-50),
                Id = 2,
                Name = "Test"
            };
            var adultSpec = new AdultSpecification();
            
            adultSpec.IsSatisfiedBy(person).Should().BeTrue();
        }

        [Fact]
        public void WhenICreatePersonWithMaleGender_WomanSpecificationShouldNotSatisfyIt()
        {
            var person = new Person()
            {
                Gender = Gender.Male,
                DateOfBirth = DateTime.Now.AddYears(-50),
                Id = 2,
                Name = "Test"
            };
            var womanSpecification = new WomanSpecification();

            womanSpecification.IsSatisfiedBy(person).Should().BeFalse();
        }
    }
}
