﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategydesignPattern
{
    public interface Strategy
    {
        int doOperation(int num1, int num2);
    }
}
