using _05BuilderPattern.v1;
using _05BuilderPattern.v4;

namespace _05BuilderPattern.v3
{
    public class LowComputerIBuilder:IComputerBuild
    {
        private Computer _computer = new Computer();

        public Computer Build()
        {
            return _computer;
        }

        public Computer SetCPU()
        {
            _computer.SetCPU("I3");
            return _computer;
        }

        public Computer SetGPU()
        {
           
            _computer.SetGPU("1060");
            return _computer;
        }

        public Computer SetHD()
        {
            _computer.SetHD("500GB");
            return _computer;
        }

        public Computer SetMemory()
        {
            _computer.SetMemory("16GB");
            return _computer;
        }
    }
}