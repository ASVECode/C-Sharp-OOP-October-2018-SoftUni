using System;
using System.Collections.Generic;
using System.Text;

namespace DemoSpace
{
    public class Sun : Star
    {
        public Sun()
        {
            Console.WriteLine("Sun");
        }
        public int NumberOfPlanet { get; } = 8;
    }
}
