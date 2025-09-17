using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public abstract class BeveragePreparation
    {
        public void PrepareBeverage()
        {
            BoilWater();
            Brew();
            PourInCup();
            AddCondiments();
        }
        protected virtual void BoilWater()
        {
            Console.WriteLine("Boiling water");
        }
        protected virtual void PourInCup()
        {
            Console.WriteLine("Pouring into cup");
        }
        protected abstract void Brew();
        protected abstract void AddCondiments();
    }
    public class Tea : BeveragePreparation
    {
        protected override void Brew()
        {
            Console.WriteLine("Steeping the tea");
        }
        protected override void AddCondiments()
        {
            Console.WriteLine("Adding lemon");
        }
    }
    public class Coffee : BeveragePreparation
    {
        protected override void Brew()
        {
            Console.WriteLine("Dripping Coffee through filter");
        }
        protected override void AddCondiments()
        {
            Console.WriteLine("Adding Sugar and Milk");
        }
    }   

}
