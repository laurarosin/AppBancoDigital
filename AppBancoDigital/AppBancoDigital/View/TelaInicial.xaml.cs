﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppBancoDigital.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TelaInicial : ContentPage
    {
        public TelaInicial()
        {
            InitializeComponent();
            btn_transf.Source = ImageSource.FromResource("AppBancoDigital.Imagem.transferencias.PNG");
            btn_pix.Source = ImageSource.FromResource("AppBancoDigital.Imagem.pix.PNG");
            btn_pagamentos.Source = ImageSource.FromResource("AppBancoDigital.Imagem.pagamentos.PNG");
            btn_cartao.Source = ImageSource.FromResource("AppBancoDigital.Imagem.cartao.PNG");
            btn_saldo.Source = ImageSource.FromResource("AppBancoDigital.Imagem.saldo.png");
            btn_barra.Source = ImageSource.FromResource("AppBancoDigital.Imagem.barra.PNG");
            btn_extrato.Source = ImageSource.FromResource("AppBancoDigital.Imagem.extrato.PNG");
            //txt_Correntista.Text = App.DadosCorrentistaLogado.Nome;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new View.EnviarPix());

        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new View.ReceberPix());
        }

        private void btn_transferencia_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new View.TelaInicial());
        }

        private void btn_pix_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new View.EnviarPix());
        }

        private void btn_cartao_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new View.TelaInicial());
        }

        private void btn_pagamentos_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new View.ReceberPix());
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {

        }

        private void btn_saldo_Clicked(object sender, EventArgs e)
        {

        }

        private void btn_barra_Clicked(object sender, EventArgs e)
        {

        }

        private void btn_extrato_Clicked(object sender, EventArgs e)
        {

        }
    }
}