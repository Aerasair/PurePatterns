using System;

namespace PurePatterns.Creational.Singleton
{
    class Singleton
    {
        private Singleton(){}

        private static Singleton _instance;

        public static Singleton GetInstance()
        {
            if(_instance == null)
            {
                _instance = new Singleton();
            }
            return _instance;
        }

        public static int Sum(int a, int b)
        {
            return a + b;
        }
    }
}
