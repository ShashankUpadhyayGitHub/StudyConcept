using System;
using System.Threading;

namespace CommonStudy
{
    public class ThreadStudy
    {
        static object lockMethod2 = new object();
        static object lockMethod3 = new object();

        public static void fun1()
        {
            for (int i = 1; i <= 5; i++)
            {
                System.Diagnostics.Debug.WriteLine("Function 1 Writes: {0}", i);
            }
        }

        public static void fun2()
        {
            for (int i = 10; i > 5; i--)
            {
                System.Diagnostics.Debug.WriteLine("Function 2 Writes: {0}", i);
            }
        }

        public static void Method1()
        {
            lock (lockMethod2)
                lock (lockMethod3)
                {
                    Console.WriteLine("Execute Method 1");
                }
        }

        public static void Method2()
        {
            lock (lockMethod2)
            {
                Console.WriteLine("Execute Method 2");
            }
        }

        public static void Method3()
        {
            lock (lockMethod3)
            {
                Console.WriteLine("Execute Method 3");
            }
        }
    }
}