using Ducks.Models.Ducks;
using Ducks.Models.Turkeys;

namespace Ducks.Adapters
{
    public class TurkeyAdapter : IDuck //target interface
    {
        //adaptee interface
        private readonly ITurkey _turkey;

        public TurkeyAdapter(ITurkey turkey)
        {
            _turkey = turkey;
        }

        public void Quack()
        {
            _turkey.Gobble();
        }

        public void Fly()
        {
            for (int i = 0; i < 5; i++)
            {
                _turkey.Fly();
            }
        }
    }
}