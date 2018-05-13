using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MagicHelper.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CarouselImageView : ContentView
	{
		public CarouselImageView (string passedImage)
		{
			InitializeComponent ();

            cardImage.Source = passedImage;
        }
	}
}