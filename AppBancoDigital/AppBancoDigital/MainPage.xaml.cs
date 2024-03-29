﻿using AppBancoDigital.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppBancoDigital
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            Imagem.Source = ImageSource.FromResource("AppBancoDigital.Imagem.Logo_Bradesco.png");
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CorrentistaCadastro());
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CorrentistaEntrar());
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {

        }
    }
}
