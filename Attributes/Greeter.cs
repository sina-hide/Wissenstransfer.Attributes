using System;

namespace Attributes
{
    [Run]
    public class Greeter
    {
        public Greeter()
        {
            Console.WriteLine("Hello Attributes!");
        }
    }

//    [Run(Priority = 2)]
    public class Greeter2
    {
        [Run(Priority = 2)]
        public Greeter2()
        {
            Console.WriteLine("Hello Attributes (2)!");
        }
    }
}