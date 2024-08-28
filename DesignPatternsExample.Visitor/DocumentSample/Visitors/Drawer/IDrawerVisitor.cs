using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternsExample.Visitor.DocumentSample.Element;

namespace DesignPatternsExample.Visitor.DocumentSample.Visitors.Drawer
{
    public interface IDrawerVisitor
    {
        string Draw(SecretDocument document);
        string Draw(ColoredDocument document);
        string Draw(BlackWhiteDocument document);
    }
}
