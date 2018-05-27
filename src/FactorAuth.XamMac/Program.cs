using AppKit;
using Eto.Forms;
using FactorAuth.Desktop;

namespace FactorAuth.XamMac
{
	static class Program
	{
		static void Main(string[] args)
		{
            var platform = new Eto.Mac.Platform();

            var app = new MainApplication(platform);

            app.Run(args);
		}
	}
}
