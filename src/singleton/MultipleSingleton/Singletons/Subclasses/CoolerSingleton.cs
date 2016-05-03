namespace MultipleSingleton.Singletons.Subclasses
{
    public class CoolerSingleton : BaseSingleton
    {
        protected new static BaseSingleton UniqueInstance;

        private CoolerSingleton() { }
    }
}