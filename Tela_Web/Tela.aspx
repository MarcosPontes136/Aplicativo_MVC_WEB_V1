<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Tela.aspx.cs" Inherits="Tela_Web.Tela" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body style="margin-left: 0px">
    <form id="form1" runat="server">
        <div style="width: 892px; height: 499px;">
            Nome:<asp:TextBox ID="TextNome" runat="server" Width="295px"></asp:TextBox> &nbsp;
            CPF:<asp:TextBox ID="TextCPF" runat="server" Width="203px"></asp:TextBox> &nbsp; <br />
            Telefone:<asp:TextBox ID="TextDDD" runat="server" Width="31px"></asp:TextBox>
            &nbsp;N°:<asp:TextBox ID="TextNumeroCelular" runat="server" Width="142px"></asp:TextBox>
            <asp:DropDownList ID="ListaTipoTelefone" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                <asp:ListItem Value="TextTipoCelular">Celular</asp:ListItem>
                <asp:ListItem Value="TextTipoFixo">Fixo</asp:ListItem>
                <asp:ListItem Value="TextTipoEmpresarial">Empresarial</asp:ListItem>
            </asp:DropDownList>
            <br /><br />

            Logradouro:<asp:TextBox ID="TextLogradouro" runat="server" Width="406px"></asp:TextBox> 
            &nbsp; 
            N°:<asp:TextBox ID="TextNumeroCasa" runat="server" Width="45px"></asp:TextBox> 
            &nbsp; 
            CEP:<asp:TextBox ID="TextCEP" runat="server"></asp:TextBox><br />
            Bairro:<asp:TextBox ID="TextBairro" runat="server" Width="246px"></asp:TextBox>
            &nbsp;
            Cidade:<asp:TextBox ID="TextCidade" runat="server" Width="135px"></asp:TextBox>
            &nbsp;
            Estado:<asp:TextBox ID="TextEstado" runat="server" Width="59px"></asp:TextBox>
            <br /><br /><br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Button ID="BtnInserir" runat="server" Text="Inserir" OnClick="BtnInserir_Click" Height="46px" Width="101px" />
            <br />
          

            <br />Consulta:<asp:TextBox ID="TextConsultaCPF" runat="server" Width="204px"></asp:TextBox>
            <asp:Button ID="BntConsultar" runat="server" Text="Ok" Width="63px" Height="26px" OnClick="BntConsultar_Click" />
            <br /><asp:ListBox ID="IbAgenda" runat="server" Height="173px" Width="713px" OnSelectedIndexChanged="IbAgenda_SelectedIndexChanged"></asp:ListBox><br />
            <asp:Button ID="BtnAlterar" runat="server" Text="Alterar" OnClick="BtnAlterar_Click" />
            <asp:Button ID="BtnExcluir" runat="server" Text="Excluir" OnClick="BtnExcluir_Click1"/>


         </div>



    </form>
</body>
</html>
