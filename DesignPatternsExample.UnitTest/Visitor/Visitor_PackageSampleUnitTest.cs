using DesignPatternsExample.Composite.Sample1;
using DesignPatternsExample.Visitor.PackageSample.Element;
using DesignPatternsExample.Visitor.PackageSample.Visitor.Buyer;
using FluentAssertions;

namespace DesignPatternsExample.UnitTest.Visitor
{
    public class Visitor_PackageSampleUnitTest
    {
        #region Package
        [Fact]
        public void WhenIHavePackageAndIndividualCustomer_AcceptShouldContainsPackage()
        {
            Package package = new Package();
            IndividualCustomer customer = new IndividualCustomer();
            var acceptResult = package.Accept(customer);
            acceptResult.Should().Contain(" Package.");
        }

        [Fact]
        public void WhenIHavePackageAndIndividualCustomer_AcceptShouldContainsIndividualCustomer()
        {
            Package package = new Package();
            IndividualCustomer customer = new IndividualCustomer();
            var acceptResult = package.Accept(customer);
            acceptResult.Should().Contain("IndividualCustomer ");
        }

        [Fact]
        public void WhenIHavePackageAndEnterpriseCustomer_AcceptShouldContainsPackage()
        {
            Package package = new Package();
            EnterpriseCustomer customer = new EnterpriseCustomer();
            var acceptResult = package.Accept(customer);
            acceptResult.Should().Contain(" Package.");
        }

        [Fact]
        public void WhenIHavePackageAndEnterpriseCustomer_AcceptShouldContainsIndividualCustomer()
        {
            Package package = new Package();
            EnterpriseCustomer customer = new EnterpriseCustomer();
            var acceptResult = package.Accept(customer);
            acceptResult.Should().Contain("EnterpriseCustomer ");
        }


        #endregion

        #region StandardPackage
        [Fact]
        public void WhenIHaveStandardPackageAndIndividualCustomer_AcceptShouldContainsStandardPackage()
        {
            StandardPackage package = new StandardPackage();
            IndividualCustomer customer = new IndividualCustomer();
            var acceptResult = package.Accept(customer);
            acceptResult.Should().Contain(" StandardPackage.");
        }

        [Fact]
        public void WhenIHaveStandardPackageAndIndividualCustomer_AcceptShouldContainsIndividualCustomer()
        {
            StandardPackage package = new StandardPackage();
            IndividualCustomer customer = new IndividualCustomer();
            var acceptResult = package.Accept(customer);
            acceptResult.Should().Contain("IndividualCustomer ");
        }

        [Fact]
        public void WhenIHaveStandardPackageAndEnterpriseCustomer_AcceptShouldContainsStandardPackage()
        {
            StandardPackage package = new StandardPackage();
            EnterpriseCustomer customer = new EnterpriseCustomer();
            var acceptResult = package.Accept(customer);
            acceptResult.Should().Contain(" StandardPackage.");
        }

        [Fact]
        public void WhenIHaveStandardPackageAndEnterpriseCustomer_AcceptShouldContainsIndividualCustomer()
        {
            StandardPackage package = new StandardPackage();
            EnterpriseCustomer customer = new EnterpriseCustomer();
            var acceptResult = package.Accept(customer);
            acceptResult.Should().Contain("EnterpriseCustomer ");
        }

        #endregion

        #region AdvancedPackage
        [Fact]
        public void WhenIHaveAdvancedPackageAndIndividualCustomer_AcceptShouldContainsAdvancedPackage()
        {
            AdvancedPackage package = new AdvancedPackage();
            IndividualCustomer customer = new IndividualCustomer();
            var acceptResult = package.Accept(customer);
            acceptResult.Should().Contain(" AdvancedPackage.");
        }

        [Fact]
        public void WhenIHaveAdvancedPackageAndIndividualCustomer_AcceptShouldContainsIndividualCustomer()
        {
            AdvancedPackage package = new AdvancedPackage();
            IndividualCustomer customer = new IndividualCustomer();
            var acceptResult = package.Accept(customer);
            acceptResult.Should().Contain("IndividualCustomer ");
        }

        [Fact]
        public void WhenIHaveAdvancedPackageAndEnterpriseCustomer_AcceptShouldContainsAdvancedPackage()
        {
            AdvancedPackage package = new AdvancedPackage();
            EnterpriseCustomer customer = new EnterpriseCustomer();
            var acceptResult = package.Accept(customer);
            acceptResult.Should().Contain(" AdvancedPackage.");
        }

        [Fact]
        public void WhenIHaveAdvancedPackageAndEnterpriseCustomer_AcceptShouldContainsIndividualCustomer()
        {
            AdvancedPackage package = new AdvancedPackage();
            EnterpriseCustomer customer = new EnterpriseCustomer();
            var acceptResult = package.Accept(customer);
            acceptResult.Should().Contain("EnterpriseCustomer ");
        }

        #endregion
    }
}