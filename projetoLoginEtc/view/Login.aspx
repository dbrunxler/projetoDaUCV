<%@ Page Title="" Language="C#" MasterPageFile="~/model/Base.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="projetoLoginEtc.view.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Faça o seu login:</h1>
    <table>
        <tr>
            <td>E-mail:</td>
            <td><asp:TextBox ID="txbEmail" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Senha:</td>
            <td><asp:TextBox ID="txbSenha" runat="server" Type="password"></asp:TextBox></td>
        </tr>
        <tr>
            <td></td>
            <td><asp:Button ID="btnLogin" runat="server" Text="Login"/></td>
        </tr>
    </table>
</asp:Content>
