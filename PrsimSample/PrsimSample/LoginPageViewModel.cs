using System;
using System.Collections.Generic;
using System.Text;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;

namespace PrsimSample
{
    public class LoginPageViewModel : BindableBase, INavigationAware
    {
        private string _title = string.Empty;
        public string Title
        {
            get { return _title; }
            set
            {
                SetProperty(ref _title,value);
            }
        }

        private INavigationService _navigationService;

        public DelegateCommand NavigateToSpeakPageCommand { get; private set; }

        public LoginPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            NavigateToSpeakPageCommand = new DelegateCommand(NavigateToSpeakPage);
        }

        private void NavigateToSpeakPage()
        {
            _navigationService.NavigateAsync("SpeakPage");
        }

        public void OnNavigatedFrom(INavigationParameters parameters)
        {

        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
            if (parameters.ContainsKey("title"))
                Title = (string)parameters["title"] + " and Prism";
        }

        public void OnNavigatingTo(INavigationParameters parameters)
        {

        }
    }
}
