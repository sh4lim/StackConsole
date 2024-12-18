using RomanLib;
using StackConsole.Core;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackConsole
{
    internal class Program
    {
        public static Proverka proverka = new Proverka();
        public static FixedStack<string> stack = new FixedStack<string>(8);
        static Swich swich = new Swich();
        
        static void Main(string[] args)
        {
            Console.WriteLine("1. добавление\n2. Удаление\n3. Вывод\n4. Вывод первого элемента\n5. Вывод последнего элемента");
            while (true)
            {
                swich.Myswitch(proverka.Type<int>("Выберите ==>"));
            }
        }
    }
}
