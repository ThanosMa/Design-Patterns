using StrategyExcercise.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyExcercise.EforiaManager
{
    public interface IEforiaStrategy
    {
        void CalculateProfit(List<Employee> employees);
        
    }
}
