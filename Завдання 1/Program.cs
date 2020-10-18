using System;
using System.Diagnostics;

namespace Завдання_1
{
    internal class Output
    {
        public virtual void Outputer(string line)
        {
            Debug.WriteLine(($"{line} и его тип = {line.GetType()}"));
            
        }
    }
    internal class OutputGreen : Output
    {
        public override void Outputer(string line)
        {
            Console.BackgroundColor = ConsoleColor.Green;
            base.Outputer($"{line} 2");
        }
    }
    internal class OutputRed : Output
    {
        public override void Outputer(string line)
        {

            Console.BackgroundColor = ConsoleColor.Red;
            base.Outputer($"{line} 3");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            string lineMain = "Наш вывод";
            
            var arr = new Output[3];
            arr[0] = new Output();
            arr[1] = new OutputGreen();
            arr[2] = new OutputRed();

            foreach (Output obj in arr)
            {
                obj.Outputer(lineMain);
            }

            string newline = ("Использование привидения типов");
            ((OutputRed)arr[2]).Outputer(newline);
            Console.ReadKey();
        }
    }
}
