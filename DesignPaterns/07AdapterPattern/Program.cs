
using System;

namespace _07AdapterPattern
{
    /// <summary>
    /// Adapter Design Pattern
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            // Non-adapted chemical compound

            Compound unknown = new Compound();
            unknown.Display();

            // Adapted chemical compounds

            Compound water = new RichCompound("水");
            water.Display();

            Compound benzene = new RichCompound("苯");
            benzene.Display();

            Compound ethanol = new RichCompound("醇");
            ethanol.Display();

            // Wait for user
            Console.ReadKey();
        }
    }

    /// <summary>
    /// 目标类  化合物
    /// </summary>
    public class Compound
    {
        protected float boilingPoint;
        protected float meltingPoint;
        protected double molecularWeight;
        protected string molecularFormula;

        public virtual void Display()
        {
            Console.WriteLine("\n化合物 未知 ------ ");
        }
    }

    /// <summary>
    /// 适配器类
    /// </summary>
    public class RichCompound : Compound
    {
        private string chemical;
        private ChemicalDatabank bank;

        // Constructor

        public RichCompound(string chemical)
        {
            this.chemical = chemical;
        }

        public override void Display()
        {
            // The Adaptee
            bank = new ChemicalDatabank();
            boilingPoint = bank.GetCriticalPoint(chemical, "B");
            meltingPoint = bank.GetCriticalPoint(chemical, "M");
            molecularWeight = bank.GetMolecularWeight(chemical);
            molecularFormula = bank.GetMolecularStructure(chemical);

            Console.WriteLine("\n化合物 {0} ------ ", chemical);
            Console.WriteLine(" 化学式: {0}", molecularFormula);
            Console.WriteLine(" 重量 : {0}", molecularWeight);
            Console.WriteLine(" 熔点 Pt: {0}", meltingPoint);
            Console.WriteLine(" 沸点 Pt: {0}", boilingPoint);
        }
    }

    /// <summary>
    /// 被适配的类
    /// </summary>
    public class ChemicalDatabank
    {
        //获取熔点,沸点方法
        public float GetCriticalPoint(string compound, string point)
        {
            //熔点
            if (point == "M")
            {
                switch (compound.ToLower())
                {
                    case "水": return 0.0f;
                    case "苯": return 5.5f;
                    case "醇": return -114.1f;
                    default: return 0f;
                }
            }
            //沸点
            else
            {
                switch (compound.ToLower())
                {
                    case "水": return 100.0f;
                    case "苯": return 80.1f;
                    case "醇": return 78.3f;
                    default: return 0f;
                }
            }
        }
        //获取分子表达式
        public string GetMolecularStructure(string compound)
        {
            switch (compound.ToLower())
            {
                case "水": return "H20";
                case "苯": return "C6H6";
                case "醇": return "C2H5OH";
                default: return "";
            }
        }
        //分子重量
        public double GetMolecularWeight(string compound)
        {
            switch (compound.ToLower())
            {
                case "水": return 18.015;
                case "苯": return 78.1134;
                case "醇": return 46.0688;
                default: return 0d;
            }
        }
    }
}
