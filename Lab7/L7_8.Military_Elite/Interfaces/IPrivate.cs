﻿using System;
using System.Collections.Generic;
using System.Text;

namespace L7_8.Military_Elite
{
    interface IPrivate : ISoldier
    {
        double Salary { get; }
    }
}
