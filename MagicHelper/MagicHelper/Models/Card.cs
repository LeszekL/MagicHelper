namespace MagicHelper.Models
{
    public class Card
    {
        private string _imageSource;

        public string Name { get; set; }

        public int ConvertedManaCost { get; set; }
        
        public string CardText { get; set; }

        public string FlavorText { get; set; }

        public string ImageSource
        {
            get
            {
                if (string.IsNullOrEmpty(_imageSource))
                {
                    return "Shots/" + Name + ".jpg";
                }
                return _imageSource;
            }
            set
            {
                _imageSource = value;
            }
        }
    }
}