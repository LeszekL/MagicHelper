﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MagicHelper.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public MainPageViewModel()
        {
            GoToGalleryCommand = new Command(() =>
            {
                new CardsGalleryViewModel();
            });

            GoToGalleryListCommand = new Command(() =>
            {
                new CardsGalleryListViewModel();
            });
        }

        public string WelcomeText
        {
            get
            {
                return "Welcome to Magic Helper!";
            }
        }

        public string GaleryButtonText
        {
            get
            {
                return "Go to cards gallery";
            }
        }

        public string CardsListButtonText
        {
            get
            {
                return "Go to cards list gallery";
            }
        }

        public ICommand GoToGalleryCommand { get; set; }

        public ICommand GoToGalleryListCommand { get; set; }


        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}