using System;
using System.Collections.Generic;
using System.Text;

namespace L7_3.Ferrari
{
    class Ferrari : IDrivable
    {
        public string Model { get; private set; }
        public string Driver { get; private set; }
        public Ferrari( string driver)
        {
            Model = "488-Spider";
            Driver = driver;
        }
        public string UseBrakes()
        {
            return "Brakes!";
        }
        public string PushGas()
        {
            return "Zadu6avam sA!";
        }
    }
}
