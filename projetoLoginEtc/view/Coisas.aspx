<%@ Page Title="" Language="C#" MasterPageFile="~/model/Base.Master" AutoEventWireup="true" CodeBehind="Coisas.aspx.cs" Inherits="projetoLoginEtc.view.Coisas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Quer calcular uma média de quatro notas?</h2>
    <table>
        <tr>
            <td>Insira a primeira média:</td>
            <td><asp:TextBox ID="txbPMed" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Insira a segunda média:</td>
            <td><asp:TextBox ID="txbSMed" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Insira a terceira média:</td>
            <td><asp:TextBox ID="txbTMed" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Insira a quarta média:</td>
            <td><asp:TextBox ID="txbQMed" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td></td>
            <td><asp:Button ID="btnCalcular" runat="server" Text="Faça o Cálculo!" OnClick="btnCalcular_Click" /></td>
        </tr>
    </table>
    <br />
    <asp:Label ID="lblResultado" runat="server" Text=" "></asp:Label>
    <br />
    <asp:ListBox ID="lstCalcMedias" runat="server"></asp:ListBox>
    <br />
    <hr />
    <h2>Vai mais alguma coisinha?</h2>
</asp:Content>
