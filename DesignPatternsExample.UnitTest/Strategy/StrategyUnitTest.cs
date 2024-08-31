using DesignPatternsExample.Strategy;
using DesignPatternsExample.Strategy.CompressionStrategy;
using DesignPatternsExample.Strategy.ReaderStrategy;
using FluentAssertions;
using System.Net;

namespace DesignPatternsExample.UnitTest.Strategy
{
    public class StrategyUnitTest
    {
        [Fact]
        public void WhenIReadFileUsingBinaryReaderStrategy_ItShouldContainRelatedTag()
        {
            var fileReader = new BinaryReaderStrategy();
            var compressor = new RarCompressionStrategy();
            var fileManager = new FileManager(fileReader,compressor);

            string address = Guid.NewGuid().ToString();
            var res = fileManager.ReadFile(address);

            res.Should().Contain(address)
                .And.Subject.Should().StartWith("<read-binary>")
                .And.Subject.Should().EndWith("</read-binary>");
        }

        [Fact]
        public void WhenIReadFileUsingStringReaderStrategy_ItShouldContainRelatedTag()
        {
            var fileReader = new StringReaderStrategy();
            var compressor = new RarCompressionStrategy();
            var fileManager = new FileManager(fileReader, compressor);

            string address = Guid.NewGuid().ToString();
            var res = fileManager.ReadFile(address);

            res.Should().Contain(address)
                .And.Subject.Should().StartWith("<read-string>")
                .And.Subject.Should().EndWith("</read-string>");
        }

    }
}

