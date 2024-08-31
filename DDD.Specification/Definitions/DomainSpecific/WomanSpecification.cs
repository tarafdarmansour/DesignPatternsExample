using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DDD.Specifications.Definitions.Common;
using DDD.Specifications.Entities;

namespace DDD.Specifications.Definitions.DomainSpecific
{
    public class WomanSpecification : Specification<Person>
    {
        public override bool IsSatisfiedBy(Person entity)
        {
            return entity.Gender == Gender.Female;
        }
    }
}
