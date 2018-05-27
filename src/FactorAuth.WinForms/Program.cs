using System;
using Eto.Forms;
using FactorAuth.Desktop;

namespace FactorAuth.WinForms
{
	class Program
	{
		[STAThread]
		public static void Main(string[] args)
		{
            var platform = new Eto.WinForms.Platform();

            var app = new MainApplication(platform);

            app.Run(args);
		}
	}
}
