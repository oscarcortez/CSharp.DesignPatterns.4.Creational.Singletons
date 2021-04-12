using System;

namespace models
{
    public class Singleton
    {
        private Singleton()
        {
        }

        private static Singleton instance;

        public static Singleton GetInstance() => instance ??= new Singleton();
        //{
            //if (instance == null)            
            //    instance = new Singleton();

            //instance ??= new Singleton();

            //return instance;

            //return instance == null ? instance : new Singleton();

            //return instance ??= new Singleton();
        //}

        public static void HacerAlgo()
        {
        }
    }
}
