namespace _01Singleton
{
    public class Singleton2
    {

        
        private static  readonly  object  locker=new object();
        private static Singleton2 _db;
        private Singleton2()
        {
            
        }
        public static Singleton2 DbFactory()
        {
            if (_db==null)
            {
                lock (locker)
                {
                    if (_db==null)
                    {
                        _db = new Singleton2();
                    }
                    
                }
                
            }

            return _db;


        }
    }


}