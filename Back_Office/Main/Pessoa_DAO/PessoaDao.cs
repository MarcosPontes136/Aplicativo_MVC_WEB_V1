using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aplicativoMVC.modelo
{
    public interface PessoaDao
    {
        void Insira(Pessoa p);
        List<Pessoa> Consulte();
        List<Pessoa> Consulte(long CPF);
        void Altere(Pessoa p);
        void Exclua(Pessoa p);
    }
}
