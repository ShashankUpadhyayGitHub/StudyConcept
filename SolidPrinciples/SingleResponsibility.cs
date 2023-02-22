using BusinessObject;
using System;

namespace SolidPrinciples
{
    class SingleResponsibility
    {
    /// <summary>
    /// A class should have only one responsibility and therefore it should have only one reason to change its code. 
    /// If a class has more than one responsibility, then there will be more than one reason to change the class
    /// </summary>
    }

    public class StudentBL
    {
        SQLRepository _dbRepo = new SQLRepository();
        Person objPerson = new Person();

        public void Save()
        {
            _dbRepo.DBSave(objPerson);
            Console.WriteLine("Student Data Save To Database.");
        }

        public void Delete()
        {
            _dbRepo.DBDelete();
            Console.WriteLine("Student Data Delete From Database.");
        }
    }

    public class SQLRepository
    {
        public bool DBSave(Person objPerson)
        {
            return true;
        }

        public bool DBDelete()
        {
            return true;
        }
    }    
}