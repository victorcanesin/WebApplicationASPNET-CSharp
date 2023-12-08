<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Cidades.aspx.cs" Inherits="WebApplication1.Cidades" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Button ID="btnIncluir" runat="server" BackColor="#66CCFF" BorderStyle="None" ForeColor="White" Height="40px" OnClick="btnIncluir_Click" Text="Incluir" Width="100px" />    
    <br />
    <br />
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" OnRowCommand="GridView1_RowCommand">
        <Columns>
            <asp:BoundField DataField="cidadeId" HeaderText="Código" />
            <asp:BoundField DataField="descricao" HeaderText="Nome da cidade" />
            <asp:BoundField DataField="ddd" HeaderText="DDD" />
            <asp:BoundField DataField="codigoIBGE" HeaderText="Código IBGE" />
            <asp:ButtonField ButtonType="Image" CommandName="alterarCidade" HeaderText="Alterar" ImageUrl="lapis.png" Text=" ">
                <FooterStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
            </asp:ButtonField>
            <asp:ButtonField ButtonType="Image" CommandName="excluirCidade" HeaderText="Excluir" ImageUrl="lixo.png" Text=" " />
        </Columns>
    </asp:GridView>
    <br />
</asp:Content>