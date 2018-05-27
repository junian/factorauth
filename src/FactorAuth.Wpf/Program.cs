using System;
using Eto.Forms;
using FactorAuth.Desktop;

namespace FactorAuth.Wpf
{
	class Program
	{
		[STAThread]
		public static void Main(string[] args)
		{
            var platform = new Eto.Wpf.Platform();

            var app = new MainApplication(platform);

            app.Run(args);
		}
	}
}
