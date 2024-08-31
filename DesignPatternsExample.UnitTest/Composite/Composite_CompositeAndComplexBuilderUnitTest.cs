using DesignPatternsExample.Composite.CompositeAndFluentBuilder;
using FluentAssertions;

namespace DesignPatternsExample.UnitTest.Composite
{
    public class Composite_CompositeAndComplexBuilderUnitTest
    {
        [Fact]
        public void WhenICreateCountryUsingCountryBuilder_ItShouldHaveName()
        {
            string countryName = "Iran";
            var county = new CountryBuilder()
                .WithName(countryName)
                .AddProvince("Tehran")
                .Build();
            county.GetName().Should().Be(countryName);
        }

        [Fact]
        public void WhenICreateCountryAndAddProvinceToIt_ItShouldContainProvince()
        {
            string provinceName = "Tehran";
            var county = new CountryBuilder()
                .WithName("Iran")
                .AddProvince(provinceName)
                .Build();
            county.GetProvinces().Should().Contain(provinceName);
        }

        [Fact]
        public void WhenICreateCountryAndAddProvincesToIt_ItShouldContainAllProvince()
        {
            string provinceName1 = "Tehran";
            string provinceName2 = "Alborz";
            var county = new CountryBuilder()
                .WithName("Iran")
                .AddProvince(provinceName1)
                .AddProvince(provinceName2)
                .Build();
            county.GetProvinces().Count.Should().Be(2);
            county.GetProvinces().Should().Contain(provinceName1);
            county.GetProvinces().Should().Contain(provinceName2);
        }
    }
}


