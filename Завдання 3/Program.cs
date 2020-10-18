using System;
using System.Runtime.InteropServices;

namespace Завдання_3
{
    class BaseClass
    {
        public int money = 2000;
        public string currencyName = "Ukrainian Dollar";
        public double exchangeValue = 28.32;

        public virtual void Show()
        {
            Console.WriteLine(money);
            Console.WriteLine(currencyName);
            Console.WriteLine(exchangeValue);
        }
    }
    class Money:BaseClass
    {
        public override void Show()
        {
            Console.WriteLine(money);
        }
    }
    class Currency:BaseClass
    {
        public override void Show()
        {
            Console.WriteLine(currencyName);
        }
    }
    class Value : BaseClass
    {
        public override void Show()
        {
            Console.WriteLine(exchangeValue);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var array = new BaseClass[3];          
            array[0] = new Money();
            array[1] = new Currency();
            array[2] = new Value();

            foreach (BaseClass obj in array)
            {
                obj.Show();
            }

        }
    }
}
