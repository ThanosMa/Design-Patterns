using StrategyExcercise.EforiaManager;
using StrategyExcercise.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyExcercise.EforiaContext
{
    public class Eforia
    {
        IEforiaStrategy strategy;
        public Eforia(IEforiaStrategy str)
        {
            strategy = str;
        }
        public void CalcProfits(List<Employee> employees)
        {
            strategy.CalculateProfit(employees);    
        }
    }
}
