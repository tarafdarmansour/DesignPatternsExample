using DesignPatternsExample.Visitor.PackageSample.Element;

namespace DesignPatternsExample.Visitor.PackageSample.Visitor.Buyer;

public class IndividualCustomer : ICustomer
{
    public string Buy(Package package)
    {
        return "IndividualCustomer is buying Package.";
    }
    public string Buy(StandardPackage package)
    {
        return "IndividualCustomer is buying StandardPackage.";
    }
    public string Buy(AdvancedPackage package)
    {
        return "IndividualCustomer is buying AdvancedPackage.";
    }
}