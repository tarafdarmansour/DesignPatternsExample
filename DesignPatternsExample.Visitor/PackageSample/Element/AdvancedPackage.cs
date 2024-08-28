using DesignPatternsExample.Visitor.PackageSample.Visitor.Buyer;

namespace DesignPatternsExample.Visitor.PackageSample.Element;

public class AdvancedPackage : Package
{
    public override string Accept(ICustomer customer) => customer.Buy(this);
}