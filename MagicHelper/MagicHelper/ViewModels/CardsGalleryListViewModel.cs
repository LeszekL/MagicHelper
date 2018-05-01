using MagicHelper.Models;
using System.Collections.Generic;
using System.ComponentModel;

namespace MagicHelper.ViewModels
{
    class CardsGalleryListViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private List<Card> _cards;

        public CardsGalleryListViewModel()
        {
            _cards = GenerateCardList();
        }

        public List<Card> Cards
        {
            get
            {
                return _cards;
            }
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private List<Card> GenerateCardList()
        {
            return new List<Card>()
            {
                new Card() { Name = "Bolt of Lightning", ConvertedManaCost = 1 },
                new Card() { Name = "Boros Charm", ConvertedManaCost = 2 },
                new Card() { Name = "Char", ConvertedManaCost = 3 },
                new Card() { Name = "Electrolyze", ConvertedManaCost = 3 },
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
        }
    }
}
