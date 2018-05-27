using System;
using FactorAuth.Core;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace FactorAuth.Mobile
{
    public partial class App : Application, IAppKernel
    {
        public App()
        {
            InitializeComponent();

            RegisterServices();

            Run(null);
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

        public void Run(string[] args)
        {
            MainPage = new MainPage();
        }

        public void RegisterServices()
        {
            
        }
    }
}
