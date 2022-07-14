using System;
namespace Facade.Structural
{
    /// <summary>
    /// Facade Design Pattern
    /// </summary>
    public class Program
    {
        public static void Main(string[] args) //Hign level programmer (Action Methods- Controller)
        {
            EurobankFacade eurobankFacade= new EurobankFacade();
            eurobankFacade.IncreaseSalaryAndGetReceipt();
            eurobankFacade.ApplyAllTaxesToEmployee();
        }
    }

    class EurobankFacade
    {
        Database Database;
        Repository Repository;
        Bank Bank;

        public EurobankFacade()
        {
            Database = new Database();
            Repository = new Repository();
            Bank = new Bank();
        }

        public void IncreaseSalaryAndGetReceipt()
        {
            Database.ConnectToDatabase();
            Database.AuthenticateToDatabase();
            Database.SyncToDatabase();
            Database.LoadToDatabase();
            Repository.LoadFromDatabase();
            Bank.IncreaseSalary();
            Bank.PrintReceipt();
        }
        public void ApplyAllTaxesToEmployee()
        {
            Database.ConnectToDatabase();
            Database.AuthenticateToDatabase();
            Database.SyncToDatabase();
            Database.LoadToDatabase();
            Repository.LoadFromDatabase();
            Bank.ApplyTaxFPA();
            Bank.ApplyTaxEFKA();
            Bank.SendSms();
        }
    }

    class Database
    {
        public void ConnectToDatabase()
        {
            Console.WriteLine("...Connecting to Database.......");
        }
        public void LoadToDatabase()
        {
            Console.WriteLine("...Loading to Database.......");
        }
        public void SyncToDatabase()
        {
            Console.WriteLine("...Synching to Database.......");
        }
        public void AuthenticateToDatabase()
        {
            Console.WriteLine("...Authenticating to Database.......");
        }
    }
    class Repository
    {
        public void LoadFromDatabase()
        {
            Console.WriteLine("...Loading From Database.......");
        }
        public void DeleteFromDatabase()
        {
            Console.WriteLine("...Deleting From Database.......");
        }
        public void EditFromDatabase()
        {
            Console.WriteLine("...Editing From Database.......");
        }
    }
    class Bank
    {
        public void IncreaseSalary()
        {
            Console.WriteLine(".....Increasing to employee.....");
        }
        public void ApplyTaxFPA()
        {
            Console.WriteLine("...Applying Tax FPA to employee .......");
        }
        public void ApplyTaxEFKA()
        {
            Console.WriteLine("...Applying Tax EFKA to employee .......");
        }
        public void PrintReceipt()
        {
            Console.WriteLine("...Print Receipt to employee .......");
        }
        public void SendSms()
        {
            Console.WriteLine("...Send SMS to employee .......");
        }
    }
}