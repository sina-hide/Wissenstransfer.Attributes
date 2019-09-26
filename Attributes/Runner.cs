using System;
using System.Linq;
using System.Reflection;

namespace Attributes
{
    internal class Runner
    {
        public static void Run()
        {
            var types =
                from type in Assembly.GetExecutingAssembly().GetTypes()
                let attribute = (RunAttribute) type
                    .GetCustomAttribute(typeof(RunAttribute))
                where attribute != null
                orderby attribute.Priority descending, type.Name
                select type;

            Type runType = types.FirstOrDefault();

            if (runType == null)
                return;

            Activator.CreateInstance(runType);

            Console.Write("Press any key to continue...");
            Console.ReadKey();        }
    }
}