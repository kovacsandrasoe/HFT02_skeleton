using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFT02_skeleton
{
    class Person
    {
        public enum SexType
        {
            male, female
        }

        public enum WorkerType
        {
            fulltime, parttime,freelancer,student
        }

        public string Name { get;  }
        public int Age { get; }
        public int Salary { get; }

        public SexType Sex { get; }

        public WorkerType WType { get; }


        public Person()
        {
            
        }

        public Person(string name, int age, int salary, SexType sex, WorkerType wtype)
        {
            this.Name = name;
            this.Age = age;
            this.Salary = salary;
            this.Sex = sex;
            this.WType = wtype;
        }

        public static List<Person> GetPersons()
        {
            List<Person> persons = new List<Person>();
            persons.Add(new Person("John", 35, 600, SexType.male, WorkerType.fulltime));
            persons.Add(new Person("Jack", 45, 400, SexType.male, WorkerType.parttime));
            persons.Add(new Person("Marie", 20, 300, SexType.female, WorkerType.fulltime));
            persons.Add(new Person("Kara", 23, 150, SexType.female, WorkerType.student));
            persons.Add(new Person("James", 63, 500, SexType.male, WorkerType.freelancer));
            persons.Add(new Person("Nick", 18, 120, SexType.male, WorkerType.student));
            persons.Add(new Person("Eric", 23, 300, SexType.male, WorkerType.freelancer));
            persons.Add(new Person("Erica", 34, 250, SexType.female, WorkerType.fulltime));
            persons.Add(new Person("Stuart", 33, 300, SexType.male, WorkerType.parttime));
            persons.Add(new Person("Barbara", 24, 260, SexType.female, WorkerType.parttime));
            return persons;
        }
    }
}
