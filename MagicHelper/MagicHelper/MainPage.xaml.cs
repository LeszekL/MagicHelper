using MagicHelper.ViewModels;
using MagicHelper.Views;
using System;
using Xamarin.Forms;

namespace MagicHelper
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            BindingContext = new MainPageViewModel();
        }

        public void OnGalleryListButtonClicked(object sender, EventArgs args)
        {
            Navigation.PushModalAsync(new CardsGalleryListViewPage());
        }
    }
}