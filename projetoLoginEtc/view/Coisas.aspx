<%@ Page Title="" Language="C#" MasterPageFile="~/model/Base.Master" AutoEventWireup="true" CodeBehind="Coisas.aspx.cs" Inherits="projetoLoginEtc.view.Coisas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="../lib/css/coisas.css" rel="stylesheet" />
    <h2>Quer calcular uma média de quatro notas?</h2>
    <div class="infoBasica">
        <p>De 0 a menos de 6 = Reprovado.</p>
        <p>De 6 a menos de 7 = Aprovado.</p>
        <p>De 7 a menos de 9 = BEM Aprovado.</p>
        <p>De 9 até 10 = MUITO Aprovado.</p>
    </div>
    <br />
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
    <br />
    <asp:ListBox ID="lstCalcMedias" runat="server"></asp:ListBox>
    <br />
    <br />
    <hr />
    <h2>Vai mais alguma coisinha? Quer fazer operações matemáticas simples?</h2>
    <table>
        <tr>
            <td>Insira o primeiro número:</td>
            <td><asp:TextBox ID="txbPrNum" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Insira o segundo número:</td>
            <td><asp:TextBox ID="txbSeNum" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td></td>
            <td><asp:Button ID="btnSomar" runat="server" Text="Soma" OnClick="btnSomar_Click" /></td>
        </tr>
        <tr>
            <td></td>
            <td><asp:Button ID="btnSubtrair" runat="server" Text="Subtração" OnClick="btnSubtrair_Click" /></td>
        </tr>
        <tr>
            <td></td>
            <td><asp:Button ID="btnMultiplicar" runat="server" Text="Multiplicação" OnClick="btnMultiplicar_Click" /></td>
        </tr>
        <tr>
            <td></td>
            <td><asp:Button ID="btnDividir" runat="server" Text="Divisão" OnClick="btnDividir_Click" /></td>
        </tr>
    </table>
    <br />
    <asp:Label ID="lblCalculos" runat="server" Text=" "></asp:Label>
    <br />
    <br />
    <asp:ListBox ID="lstCalculos" runat="server"></asp:ListBox>
    <br>
    <br />
</asp:Content>
