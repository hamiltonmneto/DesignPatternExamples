using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternExamples.Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = Example02.Singleton.getInstance();
            x.DoSomething();
        }
    }
}
