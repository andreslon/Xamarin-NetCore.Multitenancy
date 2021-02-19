using Multitenancy.Core.Interfaces;
using Multitenancy.Core.Repositories;
using Multitenancy.Core.Services;
using Multitenancy.Core.ViewModels;
using Multitenancy.Services;
using Multitenancy.Views;
using Prism;
using Prism.DryIoc;
using Prism.Ioc;
using Xamarin.Essentials.Implementation;
using Xamarin.Essentials.Interfaces;
using Xamarin.Forms;

namespace Multitenancy
{
    public partial class App
    {
        public App(IPlatformInitializer initializer) : base(initializer, setFormsDependencyResolver: true)
        {
        } 

        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync("MainPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.Register<ISettingService, SettingService>();
            containerRegistry.RegisterSingleton<IAppInfo, AppInfoImplementation>();

            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
            containerRegistry.RegisterForNavigation<AboutPage, AboutPageViewModel>();
            containerRegistry.RegisterForNavigation<ItemsPage, ItemsPageViewModel>();
            containerRegistry.RegisterForNavigation<ItemDetailPage, ItemDetailPageViewModel>();
            containerRegistry.RegisterForNavigation<NewItemPage, NewItemPageViewModel>();

            containerRegistry.Register<IDataRepository, DataRepository>();

            var settings = ((PrismApplication)Application.Current).Container.Resolve<ISettingService>();
            string[] features = settings.Features;
            switch (settings.ProjectId)
            {
                case "POKEMON":
                    containerRegistry.RegisterInstance<ITenantService>(new PokemonService(features));
                    break;
                case "DIGIMON":
                    containerRegistry.RegisterInstance<ITenantService>(new DigimonService(features));
                    break;
                default:
                    containerRegistry.RegisterInstance<ITenantService>(new TenantService(features));
                    break;
            }
            

        }
    }
}
