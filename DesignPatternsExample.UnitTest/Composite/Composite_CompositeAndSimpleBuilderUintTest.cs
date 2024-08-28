using DesignPatternsExample.Composite.CompositeAndSimpleBuilder;
using DesignPatternsExample.Composite.Sample1;

namespace DesignPatternsExample.UnitTest.Composite
{
    public class Composite_CompositeAndSimpleBuilderUintTest
    {
        [Fact]
        public void WhenICreateComplexWithBuilderMethods_ComplexCapacity_ShouldBeSumOfChildrenApartmentsCapacity()
        {

            var apartment1 = new ApartmentBuilder()
                .AddCapacity(10)
                .AddFloor(4)
                .AddName("Apartment1")
                .SetFurnished(true)
                .Build();

            var apartment2 = new ApartmentBuilder()
                .AddCapacity(4)
                .AddFloor(1)
                .AddName("Apartment2")
                .SetFurnished(false)
                .Build();

            var apartment3 = new ApartmentBuilder()
                .AddCapacity(30)
                .AddFloor(5)
                .AddName("Apartment3")
                .SetFurnished(true)
                .Build();

            var apartment4 = new ApartmentBuilder()
                .AddCapacity(15)
                .AddFloor(3)
                .AddName("Apartment4")
                .SetFurnished(false)
                .Build();

            var complex2 = new ComplexBuilder()
                .AddBuilding(apartment1)
                .AddBuilding(apartment2)
                .Build();

            var complex1 = new ComplexBuilder()
                .AddBuilding(apartment3)
                .AddBuilding(apartment4)
                .AddBuilding(complex2)
                .Build();

            Assert.Equal(complex1.Capacity(), 59);
        }

        [Fact]
        public void WhenICreateComplexWithBuilderConstructor_ComplexCapacity_ShouldBeSumOfChildrenApartmentsCapacity()
        {
            var apartment1 = new ApartmentBuilder("Apartment1,4,10,true").Build();
            var apartment2 = new ApartmentBuilder("Apartment2,1,4,false").Build();
            var apartment3 = new ApartmentBuilder("Apartment3,5,30,true").Build();
            var apartment4 = new ApartmentBuilder("Apartment4,3,15,false").Build();

            var complex2 = new ComplexBuilder()
                .AddBuilding(apartment1)
                .AddBuilding(apartment2)
                .Build();

            var complex1 = new ComplexBuilder()
                .AddBuilding(apartment3)
                .AddBuilding(apartment4)
                .AddBuilding(complex2)
                .Build();

            Assert.Equal(complex1.Capacity(), 59);
        }

        [Fact]
        public void WhenICreateComplexWithBuilderMethods_AndOneApartmentIsNotFurnished_ComplexFurnishedShouldBeFalse()
        {
            var apartment1 = new ApartmentBuilder()
                .SetFurnished(true)
                .Build();

            var apartment2 = new ApartmentBuilder()
                .SetFurnished(false)
                .Build();

            var apartment3 = new ApartmentBuilder()
                .SetFurnished(true)
                .Build();

            var apartment4 = new ApartmentBuilder()
                .SetFurnished(true)
                .Build();

            var complex2 = new ComplexBuilder()
                .AddBuilding(apartment1)
                .AddBuilding(apartment2)
                .Build();

            var complex1 = new ComplexBuilder()
                .AddBuilding(apartment3)
                .AddBuilding(apartment4)
                .AddBuilding(complex2)
                .Build();

            Assert.Equal(complex1.IsFurnished(), false);
        }

        [Fact]
        public void WhenICreateComplexWithBuilderMethods_AndAllApartmentFurnished_ComplexFurnishedShouldBeTrue()
        {
            var apartment1 = new ApartmentBuilder()
                .SetFurnished(true)
                .Build();

            var apartment2 = new ApartmentBuilder()
                .SetFurnished(true)
                .Build();

            var apartment3 = new ApartmentBuilder()
                .SetFurnished(true)
                .Build();

            var apartment4 = new ApartmentBuilder()
                .SetFurnished(true)
                .Build();

            var complex2 = new ComplexBuilder()
                .AddBuilding(apartment1)
                .AddBuilding(apartment2)
                .Build();

            var complex1 = new ComplexBuilder()
                .AddBuilding(apartment3)
                .AddBuilding(apartment4)
                .AddBuilding(complex2)
                .Build();

            Assert.Equal(complex1.IsFurnished(), true);
        }
    }
}