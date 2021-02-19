using Multitenancy.Core.Interfaces;
using Multitenancy.Core.Models;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Multitenancy.Core.ViewModels
{
    public class NewItemPageViewModel : ViewModelBase
    {
        private string text;
        private string description;
        protected IDataRepository DataStore { get; private set; }
        public NewItemPageViewModel(INavigationService navigationService, IDataRepository dataRepository)
        : base(navigationService)
        {
            DataStore = dataRepository;
            SaveCommand = new Command(OnSave, ValidateSave);
            CancelCommand = new Command(OnCancel);
            this.PropertyChanged +=
                (_, __) => SaveCommand.ChangeCanExecute();
        }

        private bool ValidateSave()
        {
            return !String.IsNullOrWhiteSpace(text)
                && !String.IsNullOrWhiteSpace(description);
        }

        public string Text
        {
            get => text;
            set => SetProperty(ref text, value);
        }

        public string Description
        {
            get => description;
            set => SetProperty(ref description, value);
        }

        public Command SaveCommand { get; }
        public Command CancelCommand { get; }

        private async void OnCancel()
        {
            // This will pop the current page off the navigation stack
            await NavigationService.GoBackAsync();
        }

        private async void OnSave()
        {
            Item newItem = new Item()
            {
                Id = Guid.NewGuid().ToString(),
                Text = Text,
                Description = Description
            };

            await DataStore.AddItemAsync(newItem);

            // This will pop the current page off the navigation stack
            await NavigationService.GoBackAsync();
        }
    }
}
