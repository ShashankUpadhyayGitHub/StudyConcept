using BusinessObject;

namespace SolidPrinciples
{
    public class DependencyInversion
    { }

    //Add intermediate class "PersonFactory" to call Person class
    public class PersonFactory
    {
        public static Person GetPersonInfo()
        {
            return new Person();
        }
    }

    //Access the Person without create the object of Person class using loosely coupled

    public class Company
    {
        public Company()
        {
        }
        public string GetPersonName()
        {
            Person objPerson = PersonFactory.GetPersonInfo();
            return objPerson.Name;
        }
    }
}