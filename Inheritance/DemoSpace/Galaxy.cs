using System;
using System.Collections.Generic;
using System.Text;

namespace DemoSpace
{
    public class Galaxy
    {
        public Galaxy()
        {
            Console.WriteLine("Galaxy");
        }
        public List<CosmicalObject> cosmicalObjects { get; set; }
    }
}
