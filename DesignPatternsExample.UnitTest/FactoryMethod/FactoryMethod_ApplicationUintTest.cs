using DesignPatternsExample.Composite.Sample1;
using DesignPatternsExample.FactoryMethod;
using FluentAssertions;

namespace DesignPatternsExample.UnitTest.FactoryMethod
{
    public class FactoryMethod_ApplicationUintTest
    {
        [Fact]
        public void WhenICreateMobileApplication_ReportShouldPrintBlackWhiteReport()
        {
            var application = new MobileApplication();
            Report report = application.CreateReport();
            report.SetData("header1","footer1");

            report.Print().Should().Contain("Printing BlackWhite Report");
            report.Print().Should().Contain("header1");
            report.Print().Should().Contain("footer1");
        }

        [Fact]
        public void WhenICreateWebApplication_ReportShouldPrintColorfulReport()
        {
            var application = new WebApplication();
            Report report = application.CreateReport();
            report.SetData("header2", "footer2");

            report.Print().Should().Contain("Printing Colorful Report");
            report.Print().Should().Contain("header2");
            report.Print().Should().Contain("footer2");
        }
    }
}