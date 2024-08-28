using DesignPatternsExample.Visitor.PackageSample.Element;

namespace DesignPatternsExample.Visitor.PackageSample.Visitor.Buyer
{
    public interface ICustomer
    {
        string Buy(Package package);
        string Buy(StandardPackage package);
        string Buy(AdvancedPackage package);
    }
}
