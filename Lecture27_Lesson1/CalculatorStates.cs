﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture27_Lesson1
{
    public enum CalculatorState
    {
        initial = 0,
        firstInputReceived = 1,
        secondInputReceived = 2
    }

    public enum OperationState
    {
        add = 0,
        sub = 1,
        mul = 2,
        div = 3
    }
}
