using Multitenancy.Core.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Multitenancy.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}