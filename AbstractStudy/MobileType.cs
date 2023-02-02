using System;

namespace AbstractStudy
{
    public abstract class MobileType
    {
        public virtual int Add(int first, int second)
        {
            return first + second;
        }

        public abstract int Subtract(int first, int second);

        public abstract void Nokia(string display);

        public abstract void Samsung(string display);

        public abstract void Redmi(string display);

        public void SwitchOff(string offClick)
        {
            Console.WriteLine("switch mobile");
        }

        public int Addition(int first, int second)
        {
            return first + second;
        }
    }
}
