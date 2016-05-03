using System;

namespace Barista
{
    public abstract class CaffeineBeverage
    {
        public void PrepareRecipe()
        {
            BoilWater();
            Brew();
            PourInCup();
            AddCondiments();
        }

        public abstract void Brew();
        public abstract void AddCondiments();

        public virtual void BoilWater()
        {
            Console.WriteLine("Boiling water");
        }

        public virtual void PourInCup()
        {
            Console.WriteLine("Pouring into cup");
        }
    }
}