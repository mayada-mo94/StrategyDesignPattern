using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDP
{
    // encapsulate behviour
    interface IFly
    {
        void Fly();
    }
    class FlyMeduimSpeed : IFly
    {
        public void Fly()
        {
            Console.WriteLine("Fly with meduim speed");
        }
    }
    class FlyNoWinds : IFly
    {
        public void Fly()
        {
            Console.WriteLine("No Wings to Fly");
        }
    }
    class FlyWithRocketSpeed: IFly
    {
        public void Fly()
        {
            Console.WriteLine("Fly Rockets Speed...");
        }
    }
}
