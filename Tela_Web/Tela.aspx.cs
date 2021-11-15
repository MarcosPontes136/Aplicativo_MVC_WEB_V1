using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using aplicativoMVC.controle;
using aplicativoMVC.modelo;

namespace Tela_Web
{
    public partial class Tela : System.Web.UI.Page
    {
        Gerenciador gerenciador;
        protected void Page_Load(object sender, EventArgs e)
        {
            gerenciador = new Gerenciador(BancoDeDados.SqlServer);
        }

        protected void BtnInserir_Click(object sender, EventArgs e)
        {
            Pessoa p = new Pessoa();
            p.nome = TextNome.Text;
            p.CPF = Convert.ToInt64(TextCPF.Text);

            Telefone t = new Telefone();
            t.DDD = Convert.ToInt32(TextDDD.Text);
            t.Numero = Convert.ToInt32(TextNumeroCelular.Text);

            Tipo_Telefone tp = new Tipo_Telefone();
            tp.Telefone_Tipo = ListaTipoTelefone.Text;

            Endereco en = new Endereco();
            en.Logradouro = TextLogradouro.Text;
            en.NumeroCasa = Convert.ToInt32(TextNumeroCasa.Text);
            en.CEP = Convert.ToInt32(TextCEP.Text);
            en.Bairro = TextBairro.Text;
            en.Cidade = TextCidade.Text;
            en.Estado = TextEstado.Text;


            gerenciador.dao.Insira(p);
            TextNome.Text = "";
        }

        protected void BtnAlterar_Click(object sender, EventArgs e)
        {
            Pessoa p = new Pessoa();
            p.nome = TextNome.Text;
            p.CPF = Convert.ToInt64(TextCPF.Text);

            Telefone t = new Telefone();
            t.DDD = Convert.ToInt32(TextDDD.Text);
            t.Numero = Convert.ToInt32(TextNumeroCelular.Text);

            Tipo_Telefone tp = new Tipo_Telefone();
            tp.Telefone_Tipo = ListaTipoTelefone.Text;

            Endereco en = new Endereco();
            en.Logradouro = TextLogradouro.Text;
            en.NumeroCasa = Convert.ToInt32(TextNumeroCasa.Text);
            en.CEP = Convert.ToInt32(TextCEP.Text);
            en.Bairro = TextBairro.Text;
            en.Cidade = TextCidade.Text;
            en.Estado = TextEstado.Text;
        }

        protected void BtnExcluir_Click1(object sender, EventArgs e)
        {
            Pessoa p = new Pessoa();
            p.nome = TextNome.Text;
            p.CPF = Convert.ToInt64(TextCPF.Text);

            Telefone t = new Telefone();
            t.DDD = Convert.ToInt32(TextDDD.Text);
            t.Numero = Convert.ToInt32(TextNumeroCelular.Text);

            Tipo_Telefone tp = new Tipo_Telefone();
            tp.Telefone_Tipo = ListaTipoTelefone.Text;

            Endereco en = new Endereco();
            en.Logradouro = TextLogradouro.Text;
            en.NumeroCasa = Convert.ToInt32(TextNumeroCasa.Text);
            en.CEP = Convert.ToInt32(TextCEP.Text);
            en.Bairro = TextBairro.Text;
            en.Cidade = TextCidade.Text;
            en.Estado = TextEstado.Text;
        }

        protected void IbAgenda_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void BntConsultar_Click(object sender, EventArgs e)
        {
            List<Pessoa> pessoas;
            if (TextConsultaCPF.Text.Equals(""))
            {
                pessoas = gerenciador.dao.Consulte();
            }
            else
            {
                pessoas = gerenciador.dao.Consulte(Convert.ToInt64(TextCPF.Text));
            }
            IbAgenda.Items.Clear();
            foreach (Pessoa p in pessoas)
            {
                IbAgenda.Items.Add(p.ToString());
            }
        }
    }
}