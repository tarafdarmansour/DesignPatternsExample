using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DDD.Specifications.Definitions.Common;
using DDD.Specifications.Entities;

namespace DDD.Specifications.Definitions.DomainSpecific
{
    public class SonSpecification : Specification<Person>
    {
        public override bool IsSatisfiedBy(Person entity)
        {
            //var sonSpec = new WomanSpecification().Not().And(new AdultSpecification().Not());
            //return sonSpec.IsSatisfiedBy(entity);
           return entity is { Age: < 18, Gender: Gender.Male };
        }
    }
}
