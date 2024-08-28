using DesignPatternsExample.Visitor.PackageSample.Visitor.Buyer;

namespace DesignPatternsExample.Visitor.PackageSample.Element;

public class Package
{
    public virtual string Accept(ICustomer customer) => customer.Buy(this);
}