using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternsExample.Visitor.DocumentSample.Visitors.Archiver;
using DesignPatternsExample.Visitor.DocumentSample.Visitors.Drawer;
using DesignPatternsExample.Visitor.DocumentSample.Visitors.Printer;

namespace DesignPatternsExample.Visitor.DocumentSample.Element
{
    public class SecretDocument : Document
    {
        public override string Accept(IPrinterVisitor printerVisitor)
        {
            return printerVisitor.Print(this);
        }

        public override string Accept(IArchiverVisitor archiverVisitor)
        {
            return archiverVisitor.Archive(this);
        }

        public override string Accept(IDrawerVisitor drawerVisitor)
        {
            return drawerVisitor.Draw(this);
        }
    }
}
