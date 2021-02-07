using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDP
{
    interface IQuack
    {
        void Quack();
    }
    class NoQuack : IQuack
    {
        public void Quack()
        {
            Console.WriteLine("No Quack");
        }
    }
    class DuckQuack : IQuack
    {
        public void Quack()
        {
            Console.WriteLine("Quack");
            Console.Beep();
        }
    }
    class Sqeek : IQuack
    {
        public void Quack()
        {
            Console.WriteLine("Sqeek");
            Console.Beep(32000,15000);
        }
    }
}
