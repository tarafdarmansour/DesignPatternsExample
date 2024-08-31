using DDD.Specifications.Definitions.DomainSpecific;
using DDD.Specifications.Entities;
using FluentAssertions;

namespace DesignPatternsExample.UnitTest.Specification
{
    public class Specification_ConstructionToOrderUnitTest
    {
        [Fact]
        public void WhenIAddWomanToManAdultFootballTeam_ItShouldRaiseInvalidOperationException()
        {
            var newMember = new Person()
            {
                Gender = Gender.Female,
                DateOfBirth = DateTime.Now.AddYears(-50),
                Id = 2,
                Name = "Test"
            };
            var footballTeam = new ManAdultFootballTeam();

            Action addMember = () => footballTeam.AddMember(newMember);
            
            addMember.Should().Throw<InvalidOperationException>();
        }

        [Fact]
        public void WhenIAddBabyToManAdultFootballTeam_ItShouldRaiseInvalidOperationException()
        {
            var newMember = new Person()
            {
                Gender = Gender.Male,
                DateOfBirth = DateTime.Now.AddYears(-1),
                Id = 2,
                Name = "Test"
            };
            var footballTeam = new ManAdultFootballTeam();

            Action addMember = () => footballTeam.AddMember(newMember);

            addMember.Should().Throw<InvalidOperationException>();
        }

        [Fact]
        public void WhenIAddAnAdultManToManAdultFootballTeam_ItShouldNotRaiseInvalidOperationException()
        {
            var newMember = new Person()
            {
                Gender = Gender.Male,
                DateOfBirth = DateTime.Now.AddYears(-30),
                Id = 2,
                Name = "Test"
            };
            var footballTeam = new ManAdultFootballTeam();

            footballTeam.AddMember(newMember);

            footballTeam.GetMembers().Should().HaveCount(1);
            footballTeam.GetMembers().Should().ContainSingle(p => p.Name == newMember.Name);
        }
    }
}
