using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyberspace.Starter
{
    public class PersonDetails : IComparable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public PersonDetails(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public int CompareTo(object obj)
        {
            PersonDetails newPerson = obj as PersonDetails;
            return this.Id.CompareTo(newPerson.Id);
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}";
        }
    }
}