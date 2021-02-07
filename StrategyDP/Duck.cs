using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDP
{
    abstract class Duck
    {
        /// <summary>
        /// Composition 
        /// Develop against Abstraction
        /// </summary>
        public IFly FlyBehaviour { get; set; }
        public IQuack QuackBehaviour { get; set; }
        public Duck(IFly _F, IQuack _Q)
        {
            FlyBehaviour = _F;
            QuackBehaviour = _Q;
        }
      
        public void Fly()
        {
            // Delegation not carry out the fly behaviour actually delegation to another method that resposible to Fly 
            FlyBehaviour.Fly();
        }
        public void Quack()
        {
            // Delegation
            QuackBehaviour.Quack();
        }
        // concreat method
        public void Swim()
        {
            Console.WriteLine("Swimming");
        }
        public abstract void Display();
    }
}
