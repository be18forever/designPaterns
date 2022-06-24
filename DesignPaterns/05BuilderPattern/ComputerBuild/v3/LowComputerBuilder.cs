using _05BuilderPattern.v1;

namespace _05BuilderPattern.v3
{
    public class LowComputerBuilder
    {
        private Computer _computer = new Computer();

        public Computer Build()
        {
            _computer.SetCPU("I3")
                .SetMemory("16GB")
                .SetGPU("1050")
                .SetHD("500GB");
            return _computer;
        }
    }
}