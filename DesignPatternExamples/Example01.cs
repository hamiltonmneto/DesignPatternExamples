using System;

namespace DesignPatternExamples.Singleton
{
    class Example01
    {
        /*How it Helps?*/
        /*
         *  The singleton design pattern  solves problems like:
         *      - How can it be ensured that a class has only one instance?
         *      - How can the sole instance of a class be accessed easily?
         *      - How can a class control its instance?
         */

        /*Implementation*/
        /*
         *  Typically, this is done by:
         *      - Declaring all constructors of the class to be private 
         *      - Providing a static method that returns a reference to the instance
         */

        public class MySingleton
        {

            private static MySingleton instance;
            private MySingleton() { }
            public static MySingleton Instance
            {
                get
                {
                    if(instance == null)
                    {
                        instance = new MySingleton();
                    }
                    return instance;
                }
            }

            public void DoSomething()
            {
                Console.WriteLine("Singleton Class with lazy initialization Code has been called");
                Console.WriteLine("A singleton is a programming design pattern which promotes code reuse of common functionality. " +
                    "It is most commonly used across major programming frameworks. " +
                    "Singleton is one of the Gang of Four design pattern and it is useful in creating applications which are flexible and promotes code ");

            }
        };
    }
}
