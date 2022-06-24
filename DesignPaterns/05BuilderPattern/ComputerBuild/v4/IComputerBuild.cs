using _05BuilderPattern.v1;

namespace _05BuilderPattern.v4
{
    public interface IComputerBuild
    {
        Computer SetCPU();
        Computer SetGPU();
        Computer SetHD();
        Computer SetMemory();
    }
}