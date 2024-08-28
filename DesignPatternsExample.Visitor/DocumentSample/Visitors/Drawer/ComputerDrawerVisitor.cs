using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternsExample.Visitor.DocumentSample.Element;

namespace DesignPatternsExample.Visitor.DocumentSample.Visitors.Drawer
{
    internal class ComputerDrawer : IDrawerVisitor
    {
        public string Draw(SecretDocument document)
        {
            return "Drawing SecretDocument using ComputerDrawer";
        }

        public string Draw(ColoredDocument document)
        {
            return "Drawing ColoredDocument using ComputerDrawer";
        }

        public string Draw(BlackWhiteDocument document)
        {
            return "Drawing BlackWhiteDocument using ComputerDrawer";
        }
    }
}
