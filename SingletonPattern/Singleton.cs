namespace SingletonPattern
{
    public class Singleton
    {
        public static Singleton _instance;

        /// <summary>
        /// Constructor
        /// </summary>
        protected Singleton()
        {}

        public static Singleton Instance()
        {
            if (_instance == null)
            {
                _instance = new Singleton();
            }

            return _instance;
        }
    }
}
