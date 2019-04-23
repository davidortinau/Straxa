using Straxa.Views;
using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Straxa
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();

            RegisterRoutes();
        }

        private void RegisterRoutes()
        {
            Routing.RegisterRoute("detail", typeof(ItemDetailPage));
        }
    }
}
