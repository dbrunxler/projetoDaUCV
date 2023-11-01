<%@ Page Title="" Language="C#" MasterPageFile="~/model/Base.Master" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="projetoLoginEtc.view.Dashboard" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Dashboard</h1>
    <h2>Bem-vindo(a) <asp:Label ID="lblUsuario" runat="server" Text=" "></asp:Label>!</h2>
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
            <td>Idade:</td>
            <td><asp:TextBox ID="txbIdade" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Email:</td>
            <td><asp:TextBox ID="txbEmail" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Senha:</td>
            <td><asp:TextBox ID="txbSenha" runat="server" Type="password"></asp:TextBox></td>
        </tr>
        <tr>
            <td></td>
            <td>
                <asp:Button ID="btnAtualizar" runat="server" Text="Atualizar" OnClick="btnAtualizar_Click" />
                <asp:Button ID="btnDeletar" runat="server" Text="Deletar" OnClick="btnDeletar_Click" />
            </td>
        </tr>
    </table>
    <br />
    <asp:GridView ID="grvUsuario" runat="server"></asp:GridView>
</asp:Content>
