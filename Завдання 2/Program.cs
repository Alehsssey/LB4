using System;

namespace Завдання_2
{
    
    class B
    {
        public int simpleInt = 16;
        public decimal money = 40;

        public virtual void MethodOne()
        {            
            Console.WriteLine(simpleInt);
        }

        public virtual bool MethodTwo()
        {
            if (simpleInt == 16)
                return true;          
            else
                return false;            
        }
    }
    class A : B
    {
        public A(int sN, decimal mN, bool tF = true)
        {
            if (!tF)            
                money = sN;
            else
            {
                simpleInt = sN;
                money = mN;
            }
            
            
        }
    }
    class B2:B
    {
        public override void MethodOne()
        {
            simpleInt = 15;
            base.MethodOne();
            
        }
    }
    class B3 : B
    {
        public override bool MethodTwo()
        {
            simpleInt = 14;
            return base.MethodTwo();    
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            B2 b2 = new B2();
            b2.MethodOne();

            B3 b3 = new B3();
            b3.MethodTwo();

            A a = new A(14, 521);
            Console.WriteLine(a.money);
        }
    }
}
