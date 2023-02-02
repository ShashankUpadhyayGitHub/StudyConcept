using System;

namespace SingletonPattern
{
    public static class SingletonInfo
    {
        public static void GetSingletonClass()
        {
            Singleton s1 = Singleton.Instance();

            Singleton s2 = Singleton.Instance();

            if (s1 == s2)
            {
                Console.WriteLine("It' same instance");
            }
        }
    }
}
