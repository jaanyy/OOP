using System;
using System.Collections.Generic;
using System.Text;

namespace L7_5.Border_Control
{
    class Robot : IIdenifiable
    {
        public string Model { get; private set; }
        public string Id { get; private set; }
        public Robot(string model, string id)
        {
            Model = model;
            Id = id;
        }

        
    }
}
