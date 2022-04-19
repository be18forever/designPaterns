using System;

namespace _02SimpleFactory
{
    public class SimpleFactory
    {
        public Food  CreateFood(string food)
        {
            if (food == "土豆")
            {
                return  new Tudou();
            }
            else if (food=="鸡翅")
            {
                return new Chicken();
            }
            else
            {
                return null;
            }
        }
      
        public abstract class Food
        {
            public abstract void PrintName();
        }
        
        public class Tudou:Food
        {
            public override void PrintName()
            {
                Console.WriteLine("我是土豆");
            }
        }
        public class Chicken:Food
        {
            public override void PrintName()
            {
                Console.WriteLine("我是鸡翅");
            }
        }
    
        
        
    }
}