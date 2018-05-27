using System;
using Eto.Forms;
using FactorAuth.Desktop;

namespace FactorAuth.Mac
{
	class Program
	{
		[STAThread]
		public static void Main(string[] args)
		{
            var platform = new Eto.Mac.Platform();

            var app = new MainApplication(platform);

            app.Run(args);
		}
	}
}
