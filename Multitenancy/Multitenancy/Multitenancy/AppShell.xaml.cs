using Multitenancy.Core.ViewModels;
using Multitenancy.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Multitenancy
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
