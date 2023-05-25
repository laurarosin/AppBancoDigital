using System;
using System.Collections.Generic;
using System.Text;

namespace AppBancoDigital.Model
{
    public class Conta
    {
        public int Id { get; set; }
        public Correntista correntista { get; set; }
        public string Tipo { get; set; }
        public string senha { get; set; }
    }
}
