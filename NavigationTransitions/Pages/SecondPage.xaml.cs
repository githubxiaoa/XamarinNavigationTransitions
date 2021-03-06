﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace NavigationTransitions
{
    public partial class SecondPage : ContentPage
    {
        void Handle_Back_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PopAsync();
        }

        void Handle_Navigate_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new ThirdPage());
        }

        public SecondPage()
        {
            InitializeComponent();
            this.BindingContext = new SecondPageModel();
        }
    }
}

