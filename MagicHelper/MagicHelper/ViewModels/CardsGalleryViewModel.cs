using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace MagicHelper.ViewModels
{
    public class CardsGalleryViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public CardsGalleryViewModel()
        {

        }


        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
