using MagicHelper.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MagicHelper
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public void OnGalleryButtonClicked(object sender, EventArgs args)
        {
            Navigation.PushModalAsync(new CardsGalleryPage());
        }

        public void OnGalleryListButtonClicked(object sender, EventArgs args)
        {
            Navigation.PushModalAsync(new CardsGalleryListViewPage());
        }
    }
}