using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elso
{
    public class Person
    {
        public int Id { get; set; }

        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public string City { get; set; }

        public Person (string firstName, string lastName, string city)
        {
            Firstname = firstName;
            Lastname = lastName;
            City = city;
        }

        public Person (int id,  string firstName, string lastName, string city)
        {
            Id = id;
            Firstname = firstName;
            Lastname=lastName;
            City = city;
        }
    }
}
