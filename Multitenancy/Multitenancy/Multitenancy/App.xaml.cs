using Multitenancy.Core.ViewModels;
using Multitenancy.Views;
using Prism;
using Prism.Ioc;
using Xamarin.Essentials.Implementation;
using Xamarin.Essentials.Interfaces;
using Xamarin.Forms;

namespace Multitenancy
{
    public partial class App
    {
        public App(IPlatformInitializer initializer): base(initializer)
        {
        }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync("NavigationPage/MainPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IAppInfo, AppInfoImplementation>();

            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
            //containerRegistry.RegisterForNavigation<AboutPage, AboutViewModel>();
            //containerRegistry.RegisterForNavigation<ItemsPage, ItemsViewModel>();
            //containerRegistry.RegisterForNavigation<ItemDetailPage, ItemDetailViewModel>();
            //containerRegistry.RegisterForNavigation<LoginPage, LoginViewModel>();
            //containerRegistry.RegisterForNavigation<NewItemPage, NewItemViewModel>();
        }
        //public App()
        //{
        //    InitializeComponent();

        //    DependencyService.Register<DataRepository>();
        //    DependencyService.Register<NavigationService>();
        //    MainPage = new AppShell();
        //} 
    }
}
