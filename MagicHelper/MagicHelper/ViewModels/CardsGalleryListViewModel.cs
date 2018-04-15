using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace MagicHelper.ViewModels
{
    class CardsGalleryListViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public CardsGalleryListViewModel()
        {

        }


        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
