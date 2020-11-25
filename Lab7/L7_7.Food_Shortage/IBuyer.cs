using System;
using System.Collections.Generic;
using System.Text;

namespace L7_7.Food_Shortage
{
    interface IBuyer
    {
        string Name { get; }
        int Food { get; }
        void BuyFood();
    }
}
