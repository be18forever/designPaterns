namespace _05BuilderPattern.v1
{
    public class ComputerBuilder
    {
        private Computer _computer = new Computer();

        public Computer Build()
        {
            _computer.SetCPU("I9")
                .SetMemory("32GB")
                .SetGPU("3060")
                .SetHD("500GB");
            return _computer;
        }
    }
}