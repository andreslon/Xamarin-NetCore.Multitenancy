using Multitenancy.Core.Interfaces;
using Multitenancy.Core.Models;
using Prism.Navigation;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Multitenancy.Core.ViewModels
{
    public class ItemsPageViewModel : ViewModelBase
    {
        protected IDataRepository DataStore { get; private set; }
        private Item _selectedItem;

        public ObservableCollection<Item> Items { get; }
        public Command LoadItemsCommand { get; }
        public Command AddItemCommand { get; }
        public Command<Item> ItemTapped { get; }

        public ItemsPageViewModel(INavigationService navigationService, IDataRepository dataRepository)
          : base(navigationService)
        {
            DataStore = dataRepository;
            Title = "Browse";
            Items = new ObservableCollection<Item>();
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());
            ItemTapped = new Command<Item>(OnItemSelected);
            AddItemCommand = new Command(OnAddItem);
        }
        public async override void Initialize(INavigationParameters parameters)
        {
            base.Initialize(parameters);
            await ExecuteLoadItemsCommand();
        }
        async Task ExecuteLoadItemsCommand()
        {
            IsBusy = true;

            try
            {
                Items.Clear();
                var items = await DataStore.GetItemsAsync(true);
                foreach (var item in items)
                {
                    Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        } 

        public Item SelectedItem
        {
            get => _selectedItem;
            set
            {
                SetProperty(ref _selectedItem, value);
                OnItemSelected(value);
            }
        }

        private async void OnAddItem(object obj)
        {
            //await NavigationService.GoToAsync("NewItemPage");
        }

        async void OnItemSelected(Item item)
        {
            if (item == null)
                return;

            // This will push the ItemDetailPage onto the navigation stack
            //await NavigationService.GoToAsync("ItemDetailPage", item.Id);
        }
    }
}