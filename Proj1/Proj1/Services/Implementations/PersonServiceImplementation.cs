using Proj1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Proj1.Services.Implementations
{
    public class PersonServiceImplementation : IPersonService
    {
        private volatile int count;

        public Person Create(Person person)
        {
            return person;
        }

        public void Delete(long id)
        {
           
        }

        public List<Person> FindAll()
        {
            List<Person> persons = new List<Person>();
            for ( int i =0; i<8; i++)
            {
                Person person = buildPerson(i);
                persons.Add(person);
            }
            return persons;
        }

        private Person buildPerson(int i)
        {
            return new Person
            {
                Id = IncrementAndGet(),
                FirstName = "Name"+ i,
                LastName = "LastName" + i,
                Gender = "Male"+ i,
                Address = "R. Araguaia"
            };
        }

        private long IncrementAndGet()
        {
            return Interlocked.Increment(ref count);
        }

        public Person FindById(long id)
        {
            return new Person
            {
                Id = 1,
                FirstName = "Caio",
                LastName = "Naim",
                Gender = "Male",
                Address = "R. Araguaia"
            };
        }

        public Person Update(Person person)
        {
            return person;
        }
    }
}
