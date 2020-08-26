using System;

namespace DemoSpace
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Galaxy milkyWay = new Galaxy();
            Galaxy andromeda = new Galaxy();

            milkyWay.cosmicalObjects.Add(new Sun());
            milkyWay.cosmicalObjects.Add(new Earth());

            for (int i = 0; i < 7; i++)
            {
                milkyWay.cosmicalObjects.Add(new Planet());
            }
            Console.WriteLine(milkyWay.ToString());
        }
    }
}
