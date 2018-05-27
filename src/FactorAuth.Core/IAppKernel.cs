using System;
namespace FactorAuth.Core
{
    public interface IAppKernel
    {
        void Run(string[] args);
        void RegisterServices();
    }
}
