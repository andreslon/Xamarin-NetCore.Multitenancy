using Multitenancy.Core.Interfaces;
using Multitenancy.Core.ViewModels;
using Multitenancy.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Multitenancy.Services
{
    public class NavigationService : INavigationService
    {
        public async Task GoToAsync(string page, string id = null)
        {
            switch (page)
            {
                case "NewItemPage":
                    await Shell.Current.GoToAsync(nameof(NewItemPage));
                    break;
                case "ItemDetailPage":
                    await Shell.Current.GoToAsync($"{nameof(ItemDetailPage)}?{nameof(ItemDetailViewModel.ItemId)}={id}");
                    break;
                case "AboutPage":
                    await Shell.Current.GoToAsync($"//{nameof(AboutPage)}");
                    break;
            }

        }
    }
}
