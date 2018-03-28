namespace MagicHelper.Models
{
    public class Card
    {
        private int _convertedManaCost;
        private string _name;
        private CardType _cardType;
        private string _cardText;
        private string _flavorText;

        public int ConvertedManaCost
        {
            get
            {
                return _convertedManaCost;
            }
            set
            {
                _convertedManaCost = value;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public CardType CardType
        {
            get
            {
                return _cardType;
            }
            set
            {
                _cardType = value;
            }
        }

        public string CardText
        {
            get
            {
                return _cardText;
            }
            set
            {
                _cardText = value;
            }
        }

        public string FlavorText
        {
            get
            {
                return _flavorText;
            }
            set
            {
                _flavorText = value;
            }
        }

        public string ImageSource
        {
            get
            {
                return "Shots/" + Name + ".jpg";
            }
        }
    }
}