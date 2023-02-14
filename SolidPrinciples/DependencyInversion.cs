using BusinessObject;
using System;

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

    //------------------------------------Example------------------------------------------------------//

    //static void Main(string[] args)
    //{
          //---UI Layer-- -
    //    MiddleLayer objML = new MiddleLayer(new SQLServerDAL());

    //    objML.PersonName = "Shashank Upadhyay";

    //    objML.Add();
    //}

    //---Middle Layer---
    public class MiddleLayer
    {
        private IDal oDal;

        public MiddleLayer(IDal _idal)
        {
            oDal = _idal;
        }

        public string PersonName { get; set; }

        //SQLServerDAL objS = new SQLServerDAL();   // -- remove tight dependency

        //OracleDAL objO = new OracleDAL(); // -- remove tight dependency

        public void Add()
        {
            // DAL Access
            //if (true)
            //    objS.Add(); //-- remove tight dependency
            //else
            //    objO.Add(); //-- remove tight dependency

            oDal.Add();
        }
    }

    //---Data Access Layer---
    public class SQLServerDAL : IDal
    {
        public void Add()
        {
            Console.WriteLine("SQL Added Successfully");
        }

        public void Delete()
        {
            Console.WriteLine("SQL Deleted Successfully");
        }

    }
    public class OracleDAL : IDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle Added Successfully");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle Deleted Successfully");
        }
    }

    public interface IDal
    {
        void Add();

        void Delete();
    }
}