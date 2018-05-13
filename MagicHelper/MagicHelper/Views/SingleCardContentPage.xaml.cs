using MagicHelper.Models;
using MagicHelper.ViewModels;
using Plugin.DeviceOrientation;
using Plugin.DeviceOrientation.Abstractions;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MagicHelper.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SingleCardContentPage : ContentPage
    {
        SingleCardViewModel _viewModel;

        public SingleCardContentPage(Card passedCard)
        {
            InitializeComponent();

            //BindingContext = _viewModel = new SingleCardViewModel(passedCard);

            //CrossDeviceOrientation.Current.LockOrientation(DeviceOrientations.Portrait);

            //image.Source = passedCard.ImageSource;

            singleCardCarousel.ItemsSource = CeateListOfProperties(passedCard);
        }

        private List<string> CeateListOfProperties(Card passedCard)
        {
            List<string> listToReturn = new List<string>();
            listToReturn.Add(passedCard.ImageSource);
            listToReturn.Add(passedCard.Name);
            listToReturn.Add(passedCard.ConvertedManaCost.ToString());

            return listToReturn;
        }
    }
}