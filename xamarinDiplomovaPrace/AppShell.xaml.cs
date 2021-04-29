using System;
using System.Collections.Generic;
using xamarinDiplomovaPrace.ViewModels;
using xamarinDiplomovaPrace.Views;
using Xamarin.Forms;

namespace xamarinDiplomovaPrace
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
