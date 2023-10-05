using System;
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
            btn_transf.Source = ImageSource.FromResource("AppBancoDigital.Imagem.tranferencias.png");
            btn_pix.Source = ImageSource.FromResource("AppBancoDigital.Imagem.pix.PNG");
            btn_pagamentos.Source = ImageSource.FromResource("AppBancoDigital.Imagem.pagamentos.PNG");
            btn_cartao.Source = ImageSource.FromResource("AppBancoDigital.Imagem.cartao.PNG");

            txt_Correntista.Text = App.DadosCorrentistaLogado.Nome;
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
            Navigation.PushAsync(new View.TelaInicial());
        }
    }
}