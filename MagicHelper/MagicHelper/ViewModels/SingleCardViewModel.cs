using MagicHelper.Models;
using System.ComponentModel;

namespace MagicHelper.ViewModels
{
    public class SingleCardViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private readonly Card _cardModel;

        public SingleCardViewModel(Card cardModel)
        {
            _cardModel = cardModel;
        }

        public string Name
        {
            get
            {
                return _cardModel.Name;
            }
        }

        public int ConvertedManaCost
        {
            get
            {
                return _cardModel.ConvertedManaCost;
            }
        }

        public string CardText
        {
            get
            {
                return _cardModel.CardText;
            }
        }

        public string FlavorText
        {
            get
            {
                return _cardModel.FlavorText;
            }
        }

        public string ImageSource
        {
            get
            {
                return _cardModel.ImageSource;
            }
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
