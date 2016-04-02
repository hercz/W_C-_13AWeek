using System;

namespace CreateClass
{
    class Person
    {
        private string name;
        private DateTime birthDate;

        public Person(String Name, DateTime birthDate)
        {
            this.Name = Name;
            this.birthDate = birthDate;
        }

        public enum Genders : int
        {
            Male, Female
        };
        public Genders gender;


        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public DateTime BirthDate
        {
            get { return birthDate; }
            set { birthDate = value; }
        }

        public override string ToString()
        {
            return String.Format("name:{0}, birth date{1}", this.name, this.birthDate);
        }
    }
}
