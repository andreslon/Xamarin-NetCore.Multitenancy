using Multitenancy.Core.Repositories;
using Multitenancy.Services;
using Multitenancy.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Multitenancy
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<DataRepository>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
