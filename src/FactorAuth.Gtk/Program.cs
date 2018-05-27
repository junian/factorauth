using System;
using Eto.Forms;
using FactorAuth.Desktop;

namespace FactorAuth.Gtk
{
	class Program
	{
		[STAThread]
		public static void Main(string[] args)
		{
            var platform = new Eto.GtkSharp.Platform();

            var app = new MainApplication(platform);

            app.Run(args);
		}
	}
}
