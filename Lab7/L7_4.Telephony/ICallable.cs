using System;
using System.Collections.Generic;
using System.Text;

namespace L7_4.Telephony
{
    public interface ICallable
    {
        string Call(string number);
    }
}
