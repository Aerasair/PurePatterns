using System;


namespace PurePatterns.Creational.Prototype
{
     class Person
    {
        public int age;
        public DateTime birthDate;
        public string name;
        public IdInfo idInfo;

        public Person ShallowCopy()
        {
            return (Person)this.MemberwiseClone();
        }

       public Person DeepCopy()
        {
            Person clone = (Person)this.MemberwiseClone();
            clone.idInfo = new IdInfo(idInfo.idNumber);
            clone.name = String.Copy(name);
            return clone;
        }
    }
}
