namespace MultipleSingleton.Singletons
{
    public class DclSingleton
    {
        private static volatile DclSingleton _uniqueInstance;
        private static readonly object SyncLock = new object();

        public static DclSingleton Instance
        {
            get
            {
                if (_uniqueInstance == null)
                {
                    lock (SyncLock)
                    {
                        if (_uniqueInstance == null)
                        {
                            _uniqueInstance = new DclSingleton();
                        }
                    }
                }
                return _uniqueInstance;
            }
        }

        private DclSingleton() { }
    }
}