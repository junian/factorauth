using System;
using System.Threading.Tasks;

namespace FactorAuth.Core.Services
{
    public interface IQRScanner
    {
        
        Task ScanFromCameraAsync();
    }
}
