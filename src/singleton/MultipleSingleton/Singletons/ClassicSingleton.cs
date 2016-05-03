namespace MultipleSingleton.Singletons
{
    // NOTE: This is not thread safe!
    public class ClassicSingleton
    {
        private static ClassicSingleton _uniqueInstance;

        public static ClassicSingleton Instance => _uniqueInstance ?? (_uniqueInstance = new ClassicSingleton());

        private ClassicSingleton() { }
    }
}