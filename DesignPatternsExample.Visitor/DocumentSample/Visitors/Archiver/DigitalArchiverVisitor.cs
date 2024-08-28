using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternsExample.Visitor.DocumentSample.Element;

namespace DesignPatternsExample.Visitor.DocumentSample.Visitors.Archiver
{
    public class DigitalArchiverVisitor : IArchiverVisitor
    {
        public string Archive(ColoredDocument document)
        {
            return "Archiving ColoredDocument with DigitalArchiver";
        }

        public string Archive(BlackWhiteDocument document)
        {
            return "Archiving BlackWhiteDocument with DigitalArchiver";
        }

        public string Archive(SecretDocument document)
        {
            return "Archiving SecretDocument with DigitalArchiver";
        }
    }
}
