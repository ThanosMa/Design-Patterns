﻿using StrategyExcercise.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyExcercise.EforiaManager
{
    public class MediumTaxStrategy:IEforiaStrategy
    {
        public void CalculateProfit(List<Employee> employees)
        {
            foreach (var emp in employees)
            {
                emp.Profit = emp.Income - emp.Income * 0.2M-20;
            }
        }
    }
}
