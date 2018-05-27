using System;
using Eto;
using Eto.Forms;
using FactorAuth.Core;
using Juniansoft.MvvmReady;

namespace FactorAuth.Desktop
{
    public class MainApplication: Application, IAppKernel
    {
        public static TrayIndicator TrayIndicator { get; internal set; }

        public MainApplication(Platform platform)
            : base(platform)
        {
            RegisterServices();
        }

        public void Run(string[] args)
        {
            this.Run(new Form());
        }

        public void RegisterServices()
        {
            
        }
    }
}
