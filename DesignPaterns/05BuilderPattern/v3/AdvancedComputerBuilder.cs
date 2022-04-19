using _05BuilderPattern.v1;

namespace _05BuilderPattern.v3
{
    public class AdvancedComputerBuilder
    {
        private Computer _computer = new Computer();

        public Computer Build()
        {
            _computer.SetCPU("I9")
                .SetMemory("32GB")
                .SetGPU("3060")
                .SetHD("1T");
            return _computer;
        }
        
    }
}