using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPMVCEX1.Models
{
    public class PersonRepository
    {
        List<Person> listOfPersons = new List<Person>();

        private readonly object _lock = new object();


        public void Add(Person p)
        {
            lock (_lock)
            {
                listOfPersons.Add(p);
            }
        }

        public List<Person> GetListOfPersons()
        {
            lock (_lock)
            {
                return listOfPersons;
            }
        }
    }
}
