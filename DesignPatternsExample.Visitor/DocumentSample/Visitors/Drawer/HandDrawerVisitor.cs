using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternsExample.Visitor.DocumentSample.Element;

namespace DesignPatternsExample.Visitor.DocumentSample.Visitors.Drawer
{
    public class HandDrawerVisitor : IDrawerVisitor
    {
        public string Draw(SecretDocument document)
        {
            return "Drawing SecretDocument using HandDrawer";
        }

        public string Draw(ColoredDocument document)
        {
            return "Drawing ColoredDocument using HandDrawer";
        }

        public string Draw(BlackWhiteDocument document)
        {
            return "Drawing BlackWhiteDocument using HandDrawer";
        }
    }
}
