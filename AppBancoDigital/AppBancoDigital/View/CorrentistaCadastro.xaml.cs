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
    public partial class CorrentistaCadastro : ContentPage
    {
        public CorrentistaCadastro()
        {
            InitializeComponent();

            
        }

        private async void btn_cadastrar_Clicked(object sender, EventArgs e)
        {
            try
            {
                await DataServiceCorrentista.Cadastrar(new Correntista
                {
                    nome = txt_Nome.Text,
                    data_nasc = dtpck_data_nasc.Date,
                    CPF = txt_cpf.Text,
                    senha = txt_Senha.Text
        
            });
                await DisplayAlert("Parabéns!", "Você foi cadastrado.", "OK");
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops", ex.Message, "OK");

            }
        }
    }
}