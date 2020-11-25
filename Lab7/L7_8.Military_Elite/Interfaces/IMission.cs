using System;
using System.Collections.Generic;
using System.Text;

namespace L7_8.Military_Elite
{
    interface IMission
    {
        string CodeName { get; }
        string State { get; }
        void CompleteMission();
    }
}
