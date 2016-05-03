namespace MultipleSingleton.Singletons
{
    public class StaticSingleton
    {
        public static StaticSingleton Instance { get; } = new StaticSingleton();

        private StaticSingleton() { }
    }
}