using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackConsole.Core
{
    internal class Swich
    {
        public void Myswitch(int i)
        {
            switch(i)
            {
                case 1:
                    Console.Write("\n==> ");
                    Program.stack.Push(Console.ReadLine());
                    break;

                case 2:
                    Program.stack.Pop(); ;
                    Console.WriteLine("\nУдаленно");
                    break;

                case 3:
                    Console.WriteLine(Program.stack.Peek());
                    break;

                case 4:
                    Program.stack.FirstItem();
                    break;

                case 5:
                    Program.stack.LastItem();
                    break;
            }
        }
    }
}
