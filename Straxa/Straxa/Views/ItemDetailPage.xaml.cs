using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Straxa.Models;
using Straxa.ViewModels;

namespace Straxa.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        ItemDetailViewModel viewModel;

        public ItemDetailPage(ItemDetailViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = this.viewModel = viewModel;
        }

        

        public ItemDetailPage()
        {
            InitializeComponent();

            var item = new Item
            {
                Text = "Item 1",
                Description = "This is an item description."
            };

            viewModel = new ItemDetailViewModel();
            BindingContext = viewModel;
        }
    }
}