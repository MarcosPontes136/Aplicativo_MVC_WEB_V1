using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aplicativoMVC.modelo
{
    class SimuladorDao : PessoaDao
    {
        // Banco de dados simulado
        private static List<Pessoa> bd = new List<Pessoa>();
        void PessoaDao.Altere(Pessoa p)
        {
            foreach (Pessoa pessoa in bd)
            {
                if (pessoa.nome.Equals(p.nome))
                {
                    pessoa.CPF = p.CPF;
                }
            }
        }

        List<Pessoa> PessoaDao.Consulte()
        {
            return bd;
        }

        List<Pessoa> PessoaDao.Consulte(Int64 CPF)
        {
            List<Pessoa> saida = new List<Pessoa>();

            foreach (Pessoa pessoa in bd)
            {
                if (pessoa.CPF.Equals(CPF))
                {
                    saida.Add(pessoa);
                }
            }

            return saida;
        }

        void PessoaDao.Exclua(Pessoa p)
        {
            bd.Remove(p);
        }

        void PessoaDao.Insira(Pessoa p)
        {
            bd.Add(p);
        }
    }
}
