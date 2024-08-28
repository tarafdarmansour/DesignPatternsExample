using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternsExample.Visitor.DocumentSample.Element;

namespace DesignPatternsExample.Visitor.DocumentSample.Visitors.Archiver
{
    public interface IArchiverVisitor
    {
        public string Archive(ColoredDocument document);
        public string Archive(BlackWhiteDocument document);
        public string Archive(SecretDocument document);
    }
}
