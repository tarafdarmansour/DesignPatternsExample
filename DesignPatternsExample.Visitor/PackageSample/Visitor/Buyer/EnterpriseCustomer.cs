using DesignPatternsExample.Visitor.PackageSample.Element;

namespace DesignPatternsExample.Visitor.PackageSample.Visitor.Buyer;

public class EnterpriseCustomer : ICustomer
{
    public string Buy(Package package)
    {
        return "EnterpriseCustomer is buying Package.";
    }
    public string Buy(StandardPackage package)
    {
        return "EnterpriseCustomer is buying StandardPackage.";
    }
    public string Buy(AdvancedPackage package)
    {
        return "EnterpriseCustomer is buying AdvancedPackage.";
    }
}