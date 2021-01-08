using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerDemo
{
    public class Person
    {
        string[] people = { "Toon", "Emre", "Ruben", "Khadija", "Timothy", "Jarno", "Donnel" };
      
        public string this[int index]
        {
            get 
            { 
                return people[index]; 
            }
            set 
            { 
                people[index] = value; 
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            Console.WriteLine(p[5] + "  " + p[3] + " " + p[2]);
        }
    }
}
