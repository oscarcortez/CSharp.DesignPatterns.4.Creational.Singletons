using System;

namespace models
{
    public class Singleton
    {
        private Singleton()
        {
        }

        private static Singleton instance;

        public static Singleton GetInstance()
        {
            //if (instance == null)            
            //    instance = new Singleton();
            instance ??= new Singleton();

            return instance;
        }

        public static void HacerAlgo()
        {
        }
    }
}
