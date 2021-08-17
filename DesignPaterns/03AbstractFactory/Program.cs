using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {

            var food1 =new EggCreator();
            var concretFood1 = food1.CreateFoodFactory();
            concretFood1.Print();


            var food2 = new MeatCreator();
            var concretFood2 = food2.CreateFoodFactory();
            concretFood2.Print();

            Console.ReadKey();
        }
        //食物
        public abstract class Food
        {
            public abstract void Print();
        }

        public class Eggs : Food
        {
            public override void Print()
            {
                Console.WriteLine("炒鸡蛋");
            }
        }
        public class Meat : Food
        {
            public override void Print()
            {
                Console.WriteLine("炒肉");
            }
        }


        /// <summary>
        /// 抽象工厂类
        /// </summary>
        public abstract class Creator
        {
            public abstract Food CreateFoodFactory();
        }
        public class EggCreator : Creator
        {
            public override Food CreateFoodFactory()
            {
                return new Eggs();
            }
        }
        public class MeatCreator : Creator
        {
            public override Food CreateFoodFactory()
            {
                return new Meat();
            }
        }

    }
}
