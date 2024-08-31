using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DDD.Specifications.Definitions.DomainSpecific;

namespace DDD.Specifications.Entities
{
    public class ManAdultFootballTeam
    {
        private IList<Person> _members = new List<Person>();
        private ManAdultSpecification _manAdultSpecification;

        public ManAdultFootballTeam()
        {
            _manAdultSpecification = new ManAdultSpecification();
        }
        public void AddMember(Person member)
        {
            if (_manAdultSpecification.IsSatisfiedBy(member))
            {
                _members.Add(member); 
            }
            else
            {
                throw new InvalidOperationException("Person is not an adult man");
            }
        }

        public IList<Person> GetMembers()
        {
            return _members;
        }
    }
}
