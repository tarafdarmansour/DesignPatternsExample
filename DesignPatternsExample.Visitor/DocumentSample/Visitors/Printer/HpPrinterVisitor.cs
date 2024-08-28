using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternsExample.Visitor.DocumentSample.Element;

namespace DesignPatternsExample.Visitor.DocumentSample.Visitors.Printer
{
    public class HpPrinterVisitor : IPrinterVisitor
    {
        public string Print(BlackWhiteDocument blackWhiteDocument)
        {
            return "Printing BlackWhiteDocument with HPPrinter";
        }

        public string Print(ColoredDocument coloredDocument)
        {
            return "Printing ColoredDocument with HPPrinter";
        }

        public string Print(SecretDocument secretDocument)
        {
            return "Printing SecretDocument with HPPrinter";
        }
    }
}
