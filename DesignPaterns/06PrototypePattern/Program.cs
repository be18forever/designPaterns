using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _06PrototypePattern
{
    class Program
    {
        //https://blog.csdn.net/zengjibing/article/details/3891115
        static void Main(string[] args)
        {
            ColorManager colormanager = new ColorManager();
            //初始化颜色
            colormanager["red"] = new ConcteteColorPrototype(255, 0, 0);
            colormanager["green"] = new ConcteteColorPrototype(0, 255, 0);
            colormanager["blue"] = new ConcteteColorPrototype(0, 0, 255);
            colormanager["angry"] = new ConcteteColorPrototype(255, 54, 0);
            colormanager["peace"] = new ConcteteColorPrototype(128, 211, 128);
            colormanager["flame"] = new ConcteteColorPrototype(211, 34, 20);
            //使用颜色
            string colorName = "red";
            ConcteteColorPrototype c1 = (ConcteteColorPrototype)colormanager[colorName].Clone();
            c1.Display(colorName);
            colorName = "peace";
            ConcteteColorPrototype c2 = (ConcteteColorPrototype)colormanager[colorName].Clone();
            c2.Display(colorName);
            colorName = "flame";
            ConcteteColorPrototype c3 = (ConcteteColorPrototype)colormanager[colorName].Clone();
            c3.Display(colorName);
            Console.ReadLine();
        }
        abstract class ColorPrototype
        {
            public abstract ColorPrototype Clone();
        }
        class ConcteteColorPrototype : ColorPrototype
        {
            private int _red, _green, _blue;
            public ConcteteColorPrototype(int red, int green, int blue)
            {
                this._red = red;
                this._green = green;
                this._blue = blue;
            }
            public override ColorPrototype Clone()
            {
                //实现浅拷贝
                return (ColorPrototype)this.MemberwiseClone();
            }
            public void Display(string _colorname)
            {
                Console.WriteLine("{0}'s RGB Values are: {1},{2},{3}",
                    _colorname, _red, _green, _blue);
            }
        }
        class ColorManager
        {
            Hashtable colors = new Hashtable();
            public ColorPrototype this[string name]
            {
                get
                {
                    return (ColorPrototype)colors[name];
                }
                set
                {
                    colors.Add(name, value);
                }
            }
        }
    }
}
