using System;
using System.Collections.Generic;
using System.Text;

namespace DemoSpace
{
    public class CosmicalObject
    {
        public CosmicalObject()
        {
            Console.WriteLine("CosmicalObject");
        }

        public int Speed { get; set; }
        public int Move()
        {
            return this.Speed * 10;
        }
    }
}
