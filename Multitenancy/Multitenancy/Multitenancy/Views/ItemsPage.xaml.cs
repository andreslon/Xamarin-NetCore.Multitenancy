using Multitenancy.Core.Models;
using Multitenancy.Core.ViewModels;
using Multitenancy.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Multitenancy.Views
{
    public partial class ItemsPage : ContentPage
    { 

        public ItemsPage()
        {
            InitializeComponent();

            //BindingContext = _viewModel = new ItemsViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing(); 
        }
    }
}