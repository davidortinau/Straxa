using System;

using Straxa.Models;
using Xamarin.Forms;

namespace Straxa.ViewModels
{
    [QueryProperty("ID", "id")]
    public class ItemDetailViewModel : BaseViewModel
    {
        public Item Item { get; set; }
        public ItemDetailViewModel(Item item = null)
        {
            Title = item?.Text;
            Item = item;
        }

        private string iD;

        public string ID
        {
            get => iD;
            set
            {
                iD = value;
                Title = iD;
            }

        }


    }
}
