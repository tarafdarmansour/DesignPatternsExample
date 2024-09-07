using DesignPatternsExample.Memento;
using DesignPatternsExample.ProtoType;
using FluentAssertions;

namespace DesignPatternsExample.UnitTest.ProtoType
{
    public class ProtoType_ReportSampleUintTest
    {
        [Fact]
        public void WhenICloneAReport_HeaderShouldBeSame()
        {
            string header = Guid.NewGuid().ToString();
            Report report = new Report(header, "", []);
            var newReport = report.Clone();
            newReport.Header.Should().Be(header);
        }

        [Fact]
        public void WhenICloneAReport_FooterShouldBeSame()
        {
            string footer = Guid.NewGuid().ToString();
            Report report = new Report("", footer, []);
            var newReport = report.Clone();
            newReport.Footer.Should().Be(footer);
        }

        [Fact]
        public void WhenICloneAReport_ContentShouldBeSame()
        {
            List<string> content = [Guid.NewGuid().ToString(), Guid.NewGuid().ToString()];
            Report report = new Report("", "", content);
            var newReport = report.Clone();
            newReport.Content.Should().ContainInOrder(content);
        }

        [Fact]
        public void WhenICloneAReport_IdShouldBeDifferent()
        {
            Report report = new Report("", "", []);
            var newReport = report.Clone();
            newReport.Id.Should().NotBe(report.Id);
        }
    }
}