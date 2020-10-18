using System;

namespace Завдання_4
{
    class ApplicationLicense
    {
        public void AllowTrial()
        {
            Console.WriteLine("Вам доступен временный режим на 30 дней");
        }
        public void AllowCommon()
        {
            Console.WriteLine("Вам доступна бесплатная версия"); 
        }
        public void AllowPro()
        {
            Console.WriteLine("Вам доступна полная версия");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int i = 3;
            while (i >= 0)
            {
                ApplicationLicense applicationLicense = new ApplicationLicense();

                string key;
                string code;
                
                    //коды доступа
                    //ПРО: 98BTVRO3HPD6
                    //ТРИАЛ: 6tr8nfyrlr42
                    //ФРИ: yf896eio0r57
                    Console.WriteLine("Введите ваш код доступа(12 символов): ");

                    key = Console.ReadLine();
                    code = key.ToUpper();

                if (code.Contains("P") && code.StartsWith("98") && code.Contains("R") && code.Contains("O"))
                {
                    applicationLicense.AllowPro();
                    break;
                }                     
                else if (code.Contains("T") && code.EndsWith("42") && code.Contains("L") && code.Contains("R"))
                {
                    applicationLicense.AllowTrial();
                    break;                   
                }                        
                else if (code.Contains("F") && code.EndsWith("57") && code.Contains("E") && code.Contains("R"))
                {
                    applicationLicense.AllowCommon();
                    break;
                }                       
                else
                {
                    Console.WriteLine("Неверный код");
                    if (i == 0)
                    {
                        Console.WriteLine("Блокировка аккаунта!");
                        break;
                    }
                    Console.WriteLine($"У вас еще {i} попыток, иначе аккаунт блокируется");
                    i--;
                    continue;
                }               
            }
            
            Console.ReadKey();


        }
    }
}
