using MagicHelper.Models;
using MagicHelper.ViewModels;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

            //BindingContext = new CardsGalleryListViewModel();

            Items = new ObservableCollection<Card>
            {
                new Card() { Name = "Bolt of Lightning" },
                new Card() { Name = "Boros Charm" },
                new Card() { Name = "Char" },
                new Card() { Name = "Electrolyze" },
                new Card() { Name = "Fire Ice" },
                new Card() { Name = "Fireblast" },
                new Card() { Name = "Firestorm" },
                new Card() { Name = "Hour of Devastation" },
                new Card() { Name = "Incinerate" },
                new Card() { Name = "Insult Injury" , ImageSource = "Shots/Insult Injury.png" },
                new Card() { Name = "Izzet Charm" },
                new Card() { Name = "Lightning Bolt" },
                new Card() { Name = "Lightning Helix" },
                new Card() { Name = "Lighting Strike", ImageSource = "Shots/Lightning Strike.png" },
                new Card() { Name = "Magma Spray" },
                new Card() { Name = "Rakdos's Return" },
                new Card() { Name = "Rolling Earthquake", ImageSource = "Shots/Rolling Earthquake.png" },
                new Card() { Name = "Searing Spear" },
                new Card() { Name = "Slagstorm" },
                new Card() { Name = "Smash to Smithereens", ImageSource = "Shots/Smash to Smithereens.png" },
                new Card() { Name = "Turn Burn" },
                new Card() { Name = "Wildfire" },
            };

            List<Card> cards = new List<Card>();

            cards.Add(new PlainswalkerCard() { Name = "Bolt of Lightning", LoyalityPoints = 5 });
            cards.Add(new CreatureCard() { Name = "Char", Toughness = 5 });

            string type1 = "Type of the Plainswalker " + cards[0].GetType();
            string type2 = "Type of the Creature " + cards[1].GetType();

            MyListView.ItemsSource = Items;
        }

        void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            Navigation.PushModalAsync(new SingleCardContentPage(e.Item as Card));

            //await DisplayAlert("Item Tapped", "An item was tapped.", "OK");

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }
    }
}
