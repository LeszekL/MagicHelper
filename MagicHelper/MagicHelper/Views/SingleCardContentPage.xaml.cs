using MagicHelper.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MagicHelper.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SingleCardContentPage : ContentPage
    {
        public SingleCardContentPage(Card passedCard)
        {
            InitializeComponent();

            image.Source = passedCard.ImageSource;
        }
    }
}