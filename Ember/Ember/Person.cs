using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ember
{
    internal class Person
    {
        public string name;
        public int age;

        public Person() { }

        public Person(string name, int age) 
        {
            this.name = name;
            this.age = age; 
        
        
        }

        public void WriteInformation() 
        {
            Console.WriteLine($"Név: {name}, Kor: {age}.");
        
        
        
        
        
        
        }











    }
}
