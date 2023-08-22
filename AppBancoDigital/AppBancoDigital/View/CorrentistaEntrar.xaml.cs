using AppBancoDigital.Model;
using AppBancoDigital.Service;
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
    public partial class CorrentistaEntrar : ContentPage
    {
        public CorrentistaEntrar()
        {
            InitializeComponent();
        }

        private async void btn_entrar_Clicked(object sender, EventArgs e)
        {
            try
            {
                Correntista correntista_logado = await DataServiceCorrentista.Entrar(new Correntista
                {
                    CPF = txt_cpf.Text.Replace(".", "").Replace("-", ""),
                    Senha = txt_Senha.Text
                });

                if(correntista_logado != null)
                {
                    App.DadosCorrentistaLogado = correntista_logado;

                    await Navigation.PushAsync(new TelaInicial());
                } else
                {
                    await DisplayAlert("Ops!", "Dados de login incorretos.", "OK");
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops", ex.Message, "OK");
            }
        }
    }
}