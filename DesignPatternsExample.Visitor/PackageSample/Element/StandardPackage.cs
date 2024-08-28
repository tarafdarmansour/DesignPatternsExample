using DesignPatternsExample.Visitor.PackageSample.Visitor.Buyer;

namespace DesignPatternsExample.Visitor.PackageSample.Element;

public class StandardPackage : Package
{
    public override string Accept(ICustomer customer) => customer.Buy(this);
}