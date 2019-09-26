using System;

namespace Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public class RunAttribute : Attribute
    {
        public int Priority { get; set; } = 1;
    }
}