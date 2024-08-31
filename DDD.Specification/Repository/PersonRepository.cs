using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DDD.Specifications.Entities;

namespace DDD.Specifications.Repository
{
    public class PersonRepository
    {
        private readonly List<Person> _people;
        public PersonRepository()
        {
            _people = GetFakePeople();
        }

        private List<Person> GetFakePeople()
        {
            List<Person> people = new List<Person>();
            for (int i = 0; i < 440; i++)
            {
                people.Add(new Person()
                {
                    DateOfBirth = DateTime.Now.AddYears(new Random().Next(1,60) * -1),
                    Gender = i % 2 == 0 ? Gender.Female : Gender.Male,
                    Id = i,
                    Name = $"user{i}"
                });
            }
            return people;
        }
        public List<Person> GetPeople() { return _people; }
    }
}
