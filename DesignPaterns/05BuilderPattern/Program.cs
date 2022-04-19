using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using _05BuilderPattern.v1;
using _05BuilderPattern.v3;

namespace _05BuilderPattern
{
    /// <summary>
    /// 以组装电脑为例子
    /// 每台电脑的组成过程都是一致的，但是使用同样的构建过程可以创建不同的表示(即可以组装成不一样的电脑，配置不一样)
    /// 组装电脑的这个场景就可以应用建造者模式来设计
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
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
            
            
            


            //返回key,valueA格式的方法
            //QueryBuilder builder = new QueryBuilder();
            //FormBodyBuilder builder = new FormBodyBuilder();
            HttpHeaderBuilder builder = new HttpHeaderBuilder();
            ConstructionProcess(builder);
            Console.WriteLine( builder.Build());
            Console.Read();
        }

        
            public static void ConstructionProcess(IKeyValueCollectionBuilder builder)
            {
                builder.Add("make", "lada")
                    .Add("colur", "red")
                    .Add("year", 1980.ToString());

            }
        

        public interface IKeyValueCollectionBuilder
        {
            IKeyValueCollectionBuilder Add(string key, string value);
        }

        /// <summary>
        /// 返回查询字符串
        /// </summary>
        public class QueryBuilder : IKeyValueCollectionBuilder
        {
            private StringBuilder _queryStringBuilder = new StringBuilder();
            public IKeyValueCollectionBuilder Add(string key, string value)
            {
                _queryStringBuilder.Append(_queryStringBuilder.Length == 0 ? "?" : "&");
                _queryStringBuilder.Append(key);
                _queryStringBuilder.Append('=');
                _queryStringBuilder.Append(Uri.EscapeDataString(value));
                return this;
            }

            public string Build()
            {
                return _queryStringBuilder.ToString();
            }
        }  
        public class FormBodyBuilder : IKeyValueCollectionBuilder
        {
            private StringBuilder _queryStringBuilder = new StringBuilder();
            public IKeyValueCollectionBuilder Add(string key, string value)
            {
                _queryStringBuilder.Append(key);
                _queryStringBuilder.Append('=');
                _queryStringBuilder.Append(value);
                _queryStringBuilder.AppendLine();
                
                return this;
            }

            public string Build()
            {
                return _queryStringBuilder.ToString();
            }
        } 
        public class HttpHeaderBuilder : IKeyValueCollectionBuilder
        {
            private StringBuilder _queryStringBuilder = new StringBuilder();
            public IKeyValueCollectionBuilder Add(string key, string value)
            {
                _queryStringBuilder.Append(key);
                _queryStringBuilder.Append(':');
                _queryStringBuilder.Append(value);
                _queryStringBuilder.AppendLine();
                
                return this;
            }

            public string Build()
            {
                return _queryStringBuilder.ToString();
            }
        } 
    }
}
