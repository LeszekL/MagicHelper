using MagicHelper.Models;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MagicHelper.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CardsGalleryListViewPage : ContentPage
    {
        public ObservableCollection<Card> Items { get; set; }

        public CardsGalleryListViewPage()
        {
            InitializeComponent();

            Items = new ObservableCollection<Card>
            {
                new Card() { Name = "Bolt of Lightning" },
                new Card() { Name = "Bolt of Lightning" },
                new Card() { Name = "Bolt of Lightning" },
                new Card() { Name = "Bolt of Lightning" },
                new Card() { Name = "Bolt of Lightning" }
            };
			
			MyListView.ItemsSource = Items;
        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            await DisplayAlert("Item Tapped", "An item was tapped.", "OK");

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }
    }
}
