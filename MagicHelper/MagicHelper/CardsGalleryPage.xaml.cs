using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MagicHelper
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CardsGalleryPage : ContentPage
    {
        public CardsGalleryPage()
        {
            InitializeComponent();

            List<Card> cardsList = GenerateCardsList();

            var layout = new StackLayout();
            foreach (Card card in cardsList)
            {
                layout.Children.Add(new Image() { WidthRequest = 100, HeightRequest = 200, Source = "Shots/" + card.Name + ".jpg" });
            }

            var scrollView = new ScrollView() { Content = layout };
            Content = scrollView;
        }

        private List<Card> GenerateCardsList()
        {
            List<Card> localCardList = new List<Card>();
            localCardList.Add(new Card() { Name = "Bolt of Lightning" });
            localCardList.Add(new Card() { Name = "Char" });
            localCardList.Add(new Card() { Name = "Char" });
            localCardList.Add(new Card() { Name = "Char" });
            localCardList.Add(new Card() { Name = "Char" });
            localCardList.Add(new Card() { Name = "Char" });
            localCardList.Add(new Card() { Name = "Char" });
            return localCardList;
        }
    }
}