using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aplicativoMVC.modelo
{
    public class Endereco
    {
        public string Endereço { get; set; }
        public string Logradouro { get; set; }
        public int NumeroCasa { get; set; }
        public int CEP { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }

    }
}
