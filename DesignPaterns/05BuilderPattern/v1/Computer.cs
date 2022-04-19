namespace _05BuilderPattern.v1
{
    public class Computer
    {

        private string _CPU;
        public Computer SetCPU(string cpu)
        {
            _CPU = cpu;
            return this;
        }
        private string _GPU;
        public Computer SetGPU(string gpu)
        {
            _GPU = gpu;
            return this;
        }
        private string _HD;
        public Computer SetHD(string hd)
        {
            _HD = hd;
            return this;
        }
        
        private string _Memory;
        public Computer SetMemory(string memory)
        {
            _Memory = memory;
            return this;
        }
        public override string ToString()
        {
            return $"Cpu:{_CPU},Gpu:{_GPU},Hd:{_HD},Memory:{_Memory}";
        }
    }
    
    
    
    
}