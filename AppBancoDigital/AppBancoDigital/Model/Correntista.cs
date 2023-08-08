using System;
using System.Collections.Generic;
using System.Text;

namespace AppBancoDigital.Model
{
   public class Correntista
    {
        public int Id_Correntista { get; set; }
        public string Nome { get; set; }    
        public string CPF { get; set; } 
        public DateTime data_nasc { get; set; }   
        public string Senha { get; set; }   

    }
}
