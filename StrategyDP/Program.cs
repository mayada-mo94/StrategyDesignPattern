using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDP
{
    class Program
    {

        //strategy allow to change the alogiratiom you already working with in the run time without any change in code
        static void Main(string[] args)
        {
            Duck MallDuck = new MallDuck();
            MallDuck.Display();
            MallDuck.Fly();

            Console.WriteLine("Hunting Mode");
            MallDuck.FlyBehaviour = new FlyWithRocketSpeed();
            MallDuck.QuackBehaviour = new Sqeek();
            MallDuck.Display();
            MallDuck.Quack();
            MallDuck.Fly();
            Console.ReadKey();
        }
    }
}
