using System.Collections.Generic;

namespace WindowsFormsApp1
{
    internal class Person
    {
        public string Name { get; set; } 
        public string Surname { get; set; }
        public string BirthDate { get; set; }
        public List<Person> Parents { get; } = new List<Person>();

        public Person(string name, string surname, string birthDate)
        {
            Name = name;
            Surname = surname;
            BirthDate = birthDate;
        }
    }
}
