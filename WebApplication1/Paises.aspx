<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Paises.aspx.cs" Inherits="WebApplication1.Paises" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Button ID="btnIncluir" runat="server" BackColor="#66CCFF" BorderStyle="None" ForeColor="White" Height="40px" Text="Incluir" Width="100px" OnClick="btnIncluir_Click" />
    <br />
    <br />
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" OnRowCommand="GridView1_RowCommand">
        <Columns>
            <asp:BoundField DataField="paisID" HeaderText="Código" />
            <asp:BoundField DataField="paisDescricao" HeaderText="Nome do país" />
            <asp:BoundField DataField="paisSigla" HeaderText="Sigla" />
            <asp:ButtonField ButtonType="Image" CommandName="alterarPais" HeaderText="Alterar" ImageUrl="lapis.png" Text=" ">
                <FooterStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
            </asp:ButtonField>
            <asp:ButtonField ButtonType="Image" CommandName="excluirPais" HeaderText="Excluir" ImageUrl="lixo.png" Text=" " />
        </Columns>
    </asp:GridView>
</asp:Content>
