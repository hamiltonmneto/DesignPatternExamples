using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;

namespace DesignPatternExamples.Singleton
{
    class Example02
    {
        public class Singleton
        {
            private static volatile Singleton INSTANCE;
            private Singleton() { }

            public static Singleton getInstance()
            {
                if (INSTANCE == null)
                {
                    lock (new Object())
                    {
                        INSTANCE = new Singleton();
                    }

                }
                return INSTANCE;
            }

            public void DoSomething()
            {
                Console.WriteLine("Singleton Class with lazy initialization multi thread Code has been called");
            }
        }
    }
}
