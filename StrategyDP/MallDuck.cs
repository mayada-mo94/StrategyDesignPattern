using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDP
{
    class MallDuck :Duck
    {
        public MallDuck()
            :base (new FlyMeduimSpeed(),new DuckQuack())
        {

        }

        public override void Display()
        {
            Console.WriteLine("Mall Duck");
        }
    }
}
