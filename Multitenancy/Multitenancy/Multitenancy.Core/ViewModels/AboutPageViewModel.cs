using Multitenancy.Core.Interfaces;
using Prism.Navigation;
using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Multitenancy.Core.ViewModels
{
    public class AboutPageViewModel : ViewModelBase
    {
        public ITenantService TenantService { get; set; }
        public string WhatEver { get; set; }
        public AboutPageViewModel(INavigationService navigationService, ITenantService tenantService) : base(navigationService)
        {
            Title = "About";
            TenantService = tenantService;
            WhatEver = TenantService.Greeting;
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));
        }

        public ICommand OpenWebCommand { get; }
    }
}