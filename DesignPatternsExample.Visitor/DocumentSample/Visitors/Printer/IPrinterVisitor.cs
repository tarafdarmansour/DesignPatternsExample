using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternsExample.Visitor.DocumentSample.Element;

namespace DesignPatternsExample.Visitor.DocumentSample.Visitors.Printer
{
    public interface IPrinterVisitor
    {
        string Print(BlackWhiteDocument blackWhiteDocument);
        string Print(ColoredDocument coloredDocument);
        string Print(SecretDocument secretDocument);
    }
}
