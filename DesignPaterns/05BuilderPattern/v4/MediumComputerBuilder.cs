using _05BuilderPattern.v1;

namespace _05BuilderPattern.v3
{
    public class MediumComputerIBuilder
    {
        private Computer _computer = new Computer();

        public Computer Build()
        {
            _computer.SetCPU("I5")
                .SetMemory("16GB")
                .SetGPU("1060")
                .SetHD("500GB");
            return _computer;
        }
    }
}