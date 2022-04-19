using System;

namespace _01Singleton
{
    
    
  
    public  class Singleton
    {

        private static readonly object locker = new object();

        private static Singleton _singleton;

        private Singleton()
        {
            
        }
        //单例模式
        public static Singleton GetSingleton()
        {

                if (_singleton==null)
                {
                    lock (locker)
                    {
                        if (_singleton==null)
                        {
                            _singleton = new Singleton();

                        }
                    }
                    
                }

                return _singleton;
        }
    }
}