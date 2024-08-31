using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DDD.Specifications.Definitions.Common;
using DDD.Specifications.Entities;

namespace DDD.Specifications.Definitions.DomainSpecific
{
    public class ManAdultSpecification : Specification<Person>
    {
        public override bool IsSatisfiedBy(Person entity)
        {
            var spec = new WomanSpecification().Not().And(new AdultSpecification());
            return spec.IsSatisfiedBy(entity);
        }
    }
}
