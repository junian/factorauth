using System;
using System.Windows.Input;
using Juniansoft.MvvmReady;

namespace FactorAuth.Core.ViewModels
{
    public class HelloViewModel: BaseViewModel
    {
        public HelloViewModel()
        {
        }

        private string helloMessage;
        public string HelloMessage
        {
            get => helloMessage;
            set => Set(ref helloMessage, value);
        }

        public ICommand SayHelloCommand => new Command((name) => 
        {
            HelloMessage = $"Hello, {name}";
        });
    }
}
