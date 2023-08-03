using AppBancoDigital.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppBancoDigital.Service
{
   public class DataServiceCorrentista : DataService   
    {
     

        public static async Task<Correntista> Entrar(Correntista c)
        {
            var json_a_enviar = JsonConvert.SerializeObject(c);

            string json = await DataService.PostDataToService(json_a_enviar, "/correntista/entrar");

            Correntista p = JsonConvert.DeserializeObject<Correntista>(json);

            return c;
        }
        
        public static async Task<Correntista> Cadastrar(Correntista c)
        {
            var json_a_enviar = JsonConvert.SerializeObject(c);

            string json = await DataService.PostDataToService(json_a_enviar, "/correntista/salvar");

            Correntista p = JsonConvert.DeserializeObject<Correntista>(json);

            return c;
        }

    }
}
