using _05BuilderPattern.v1;
using _05BuilderPattern.v4;

namespace _05BuilderPattern.v3
{
    public class AdvancedComputerIBuilder:IComputerBuild
    {
        private Computer _computer = new Computer();

        public Computer Build()
        {
            return _computer;
        }

        public Computer SetCPU()
        {
            _computer.SetCPU("I9");
            return _computer;
        }

        public Computer SetGPU()
        {
           
            _computer.SetGPU("3060");
            return _computer;
        }

        public Computer SetHD()
        {
            _computer.SetHD("1T");
            return _computer;
        }

        public Computer SetMemory()
        {
            _computer.SetMemory("32GB");
            return _computer;
        }
    }
}