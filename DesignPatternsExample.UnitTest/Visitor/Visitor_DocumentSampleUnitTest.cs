using DesignPatternsExample.Composite.Sample1;
using DesignPatternsExample.Visitor.DocumentSample.Element;
using DesignPatternsExample.Visitor.DocumentSample.Visitors.Archiver;
using DesignPatternsExample.Visitor.DocumentSample.Visitors.Drawer;
using DesignPatternsExample.Visitor.DocumentSample.Visitors.Printer;
using DesignPatternsExample.Visitor.PackageSample.Element;
using DesignPatternsExample.Visitor.PackageSample.Visitor.Buyer;
using FluentAssertions;

namespace DesignPatternsExample.UnitTest.Visitor
{
    public class Visitor_DocumentSampleUnitTest
    {
        #region ColoredDocument
        [Fact]
        public void WhenIHaveColoredDocumentAndDigitalArchiver_ArchiveShouldContainsColoredDocument()
        {
            ColoredDocument document = new ColoredDocument();
            DigitalArchiverVisitor archiverVisitor = new DigitalArchiverVisitor();
            var acceptResult = document.Accept(archiverVisitor);
            acceptResult.Should().Contain(" ColoredDocument ");
        }

        [Fact]
        public void WhenIHaveColoredDocumentAndDigitalArchiver_ArchiveShouldContainsDigitalArchiver()
        {
            ColoredDocument document = new ColoredDocument();
            DigitalArchiverVisitor archiverVisitor = new DigitalArchiverVisitor();
            var acceptResult = document.Accept(archiverVisitor);
            acceptResult.Should().Contain(" DigitalArchiver");
        }

        [Fact]
        public void WhenIHaveColoredDocumentAndHandDrawer_DrawShouldContainsColoredDocument()
        {
            ColoredDocument document = new ColoredDocument();
            HandDrawerVisitor drawerVisitor = new HandDrawerVisitor();
            var acceptResult = document.Accept(drawerVisitor);
            acceptResult.Should().Contain(" ColoredDocument ");
        }

        [Fact]
        public void WhenIHaveColoredDocumentAndHandDrawer_DrawShouldContainsHandDrawer()
        {
            ColoredDocument document = new ColoredDocument();
            HandDrawerVisitor drawerVisitor = new HandDrawerVisitor();
            var acceptResult = document.Accept(drawerVisitor);
            acceptResult.Should().Contain(" HandDrawer");
        }

        [Fact]
        public void WhenIHaveColoredDocumentAndEpsonPrinter_PrintShouldContainsColoredDocument()
        {
            ColoredDocument document = new ColoredDocument();
            EpsonPrinterVisitor printerVisitor = new EpsonPrinterVisitor();
            var acceptResult = document.Accept(printerVisitor);
            acceptResult.Should().Contain(" ColoredDocument ");
        }

        [Fact]
        public void WhenIHaveColoredDocumentAndEpsonPrinter_PrintShouldContainsEpsonPrinter()
        {
            ColoredDocument document = new ColoredDocument();
            EpsonPrinterVisitor printerVisitor = new EpsonPrinterVisitor();
            var acceptResult = document.Accept(printerVisitor);
            acceptResult.Should().Contain(" EpsonPrinter");
        }

        [Fact]
        public void WhenIHaveColoredDocumentAndHPPrinter_PrintShouldContainsColoredDocument()
        {
            ColoredDocument document = new ColoredDocument();
            HpPrinterVisitor printerVisitor = new HpPrinterVisitor();
            var acceptResult = document.Accept(printerVisitor);
            acceptResult.Should().Contain(" ColoredDocument ");
        }

        [Fact]
        public void WhenIHaveColoredDocumentAndHPPrinter_PrintShouldContainsHPPrinter()
        {
            ColoredDocument document = new ColoredDocument();
            HpPrinterVisitor printerVisitor = new HpPrinterVisitor();
            var acceptResult = document.Accept(printerVisitor);
            acceptResult.Should().Contain(" HPPrinter");
        }

        [Fact]
        public void WhenIHaveColoredDocumentAndSamsungPrinter_PrintShouldContainsColoredDocument()
        {
            ColoredDocument document = new ColoredDocument();
            SamsungPrinterVisitor printerVisitor = new SamsungPrinterVisitor();
            var acceptResult = document.Accept(printerVisitor);
            acceptResult.Should().Contain(" ColoredDocument ");
        }

        [Fact]
        public void WhenIHaveColoredDocumentAndSamsungPrinter_PrintShouldContainsSamsungPrinter()
        {
            ColoredDocument document = new ColoredDocument();
            SamsungPrinterVisitor printerVisitor = new SamsungPrinterVisitor();
            var acceptResult = document.Accept(printerVisitor);
            acceptResult.Should().Contain(" SamsungPrinter");
        }
        #endregion
    }
}