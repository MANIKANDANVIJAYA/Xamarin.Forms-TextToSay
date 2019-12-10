using System;
using System.Collections.Generic;
using System.Text;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Commands;
namespace PrsimSample
{
    public class SpeakPageViewModel : BindableBase, INavigationAware
    {
        private INavigationService _navigationService;

        private string _textToSay = "Hello Prism";
        public string TextToSay
        {
            get { return _textToSay; }
            set { SetProperty(ref _textToSay, value); }
        }

        public DelegateCommand SpeakCommand { get; set; }

        public SpeakPageViewModel()
        {
            SpeakCommand = new DelegateCommand(Speak);
        }

        private void Speak()
        {
            _navigationService.NavigateAsync("LoginPage");
            //TODO: call service
    }

    public void OnNavigatedFrom(INavigationParameters parameters)
        {

        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {

        }

        public void OnNavigatingTo(INavigationParameters parameters)
        {

        }
    }
}
