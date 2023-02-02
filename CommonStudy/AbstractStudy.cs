using System;

namespace CommonStudy
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

    public class MobileAccess : MobileType
    {
        public new int Add(int first, int second)
        {
            return (first + second) / 100;
        }

        public override int Subtract(int first, int second)
        {
            return first - second;
        }

        public override void Nokia(string display)
        {
            Console.WriteLine("Start Nokia");
        }

        public override void Samsung(string display)
        {
            Console.WriteLine("Start Samsung");
        }

        public override void Redmi(string display)
        {
            Console.WriteLine("Start Redmi");
        }
    }

    public class AbstractStudy : MobileAccess
    {
        public void MobileAccessType()
        {
            MobileType obj = new MobileAccess();
            obj.Add(1, 2);
            obj.Addition(1, 2);

            obj.SwitchOff("BulletedListDisplayMode");
        }
    }
}
