using StrategyExcercise.EforiaContext;
using StrategyExcercise.EforiaManager;
using StrategyExcercise.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyExcercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee() { Name = "Thanos", Income = 50000 };
            Employee e2 = new Employee() { Name = "Mairy", Income = 42000 };
            Employee e3 = new Employee() { Name = "George", Income = 26000 };

            List<Employee> employees = new List<Employee>() { e1, e2, e3 };

            Eforia eforia = new Eforia(new HighTaxStrategy()); //Edw allazw strategy
            eforia.CalcProfits(employees);
            Console.WriteLine("------------------------");
            foreach (var emp in employees)
            {
                Console.WriteLine($"{emp.Name, -15}{emp.Income,-15}{emp.Profit,-15}");
            }

        }
    }
}
