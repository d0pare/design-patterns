namespace MultipleSingleton.Singletons
{
    public class ThreadSafeSingleton
    {
        private static ThreadSafeSingleton _uniqueInstance;
        private static readonly object SyncLock = new object();

        public static ThreadSafeSingleton Instance
        {
            get
            {
                lock (SyncLock)
                {
                    if (_uniqueInstance == null)
                    {
                        _uniqueInstance = new ThreadSafeSingleton();
                    }
                }

                return _uniqueInstance;
            }
        }

        private ThreadSafeSingleton() { }
    }
}