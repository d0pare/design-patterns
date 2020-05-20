namespace MultipleSingleton.Singletons
{
    public class BaseSingleton
    {
        protected static BaseSingleton UniqueInstance;
        private static readonly object SyncLock = new object();

        public static BaseSingleton Instance
        {
            get
            {
                lock (SyncLock)
                {
                    if (UniqueInstance == null)
                    {
                        UniqueInstance = new BaseSingleton();
                    }
                }

                return UniqueInstance;
            }
        }

        protected BaseSingleton() { }
    }
}