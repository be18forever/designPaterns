using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using _05BuilderPattern.KeyValueCollection;
using _05BuilderPattern.v1;
using _05BuilderPattern.v3;

namespace _05BuilderPattern
{
    /// <summary>
    /// 两个例子,一个组装电脑,一个返回查询参数
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            #region 组装电脑示例 
            /// 以组装电脑为例子
            /// 每台电脑的组成过程都是一致的，但是使用同样的构建过程可以创建不同的表示(即可以组装成不一样的电脑，配置不一样)
            /// 组装电脑的这个场景就可以应用建造者模式来设计

            //组装电脑V1版本
            Computer computer = new Computer();
            computer.SetCPU("I9");
            computer.SetGPU("3060");
            computer.SetMemory("32GB");
            computer.SetHD("500GB");
            Console.WriteLine(computer.ToString());
            
            //组装电脑V2版本--缺点：不同用户需求不同的电脑，但是只能返回同一款电脑
            ComputerBuilder computerBuilder = new ComputerBuilder();
            var computerV2 = computerBuilder.Build();
            Console.WriteLine(computerV2.ToString());
            
            //组装电脑V3版本--缺点：代码重复，并且如果忘记配置其中一项，代码不会报错
            LowComputerBuilder lowComputerBuilder = new LowComputerBuilder();
            var lowComputer = lowComputerBuilder.Build();
            Console.WriteLine(lowComputer.ToString());

            MediumComputerBuilder mediumComputerBuilder = new MediumComputerBuilder();
            var mediumComp = mediumComputerBuilder.Build();
            Console.WriteLine(mediumComp.ToString());

            AdvancedComputerBuilder advancedComputerBuilder = new AdvancedComputerBuilder();
            var advanceComputer = advancedComputerBuilder.Build();
            Console.WriteLine(advanceComputer.ToString());
            #endregion



            #region 返回key,valueA格式的方法示例 
            QueryBuilder queryBuilder = new QueryBuilder();
            KeyValueBuilder.ConstructionProcess(queryBuilder);
            Console.WriteLine(queryBuilder.Build());

            HttpHeaderBuilder builder = new HttpHeaderBuilder();
            KeyValueBuilder.ConstructionProcess(builder);
            Console.WriteLine( builder.Build());

            FormBodyBuilder formBodyBuilder = new FormBodyBuilder();
            KeyValueBuilder.ConstructionProcess(formBodyBuilder);
            Console.WriteLine(formBodyBuilder.Build());
            Console.Read();
            #endregion
        }


      
    }
}
