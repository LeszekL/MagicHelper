using MagicHelper.Models;
using MagicHelper.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MagicHelper.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CardsGalleryListViewPage : ContentPage
    {
        public CardsGalleryListViewPage()
        {
            InitializeComponent();

            BindingContext = new CardsGalleryListViewModel();
        }

        void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            Navigation.PushModalAsync(new SingleCardContentPage(e.Item as Card));

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }
    }
}
