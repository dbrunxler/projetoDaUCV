<%@ Page Title="" Language="C#" MasterPageFile="~/model/Base.Master" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="projetoLoginEtc.view.Registro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Faça o seu registro!</h1>
    <table>
        <tr>
            <td>Nome:</td>
            <td><asp:TextBox ID="txbNome" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Sobrenome:</td>
            <td><asp:TextBox ID="txbSobrenome" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>E-mail:</td>
            <td><asp:TextBox ID="txbEmail" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Idade:</td>
            <td><asp:TextBox ID="txbIdade" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Senha:</td>
            <td><asp:TextBox ID="txbSenha" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td></td>
            <td><asp:Button ID="btnRegistro" runat="server" Text="Registra-se" OnClick="btnRegistro_Click" /></td>
        </tr>
    </table>
    <br />
    <asp:GridView ID="grvUsuarios" runat="server"></asp:GridView>
</asp:Content>
