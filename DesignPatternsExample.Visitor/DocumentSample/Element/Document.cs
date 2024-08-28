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
    public abstract class Document
    {
        public abstract string Accept(IPrinterVisitor printerVisitor);
        public abstract string Accept(IArchiverVisitor archiverVisitor);
        public abstract string Accept(IDrawerVisitor drawerVisitor);

    }
}
