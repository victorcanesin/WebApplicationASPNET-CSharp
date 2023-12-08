<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadastroEstados.aspx.cs" Inherits="WebApplication1.CadastroEstados" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <div class="row">
      <div class="input-field col s2">
          <asp:TextBox ID="txtCodigoEstado" runat="server"></asp:TextBox>
          <label for="txtCodigoEstado">Código do estado</label>
      </div>
      <div class="input-field col s5">
          <asp:TextBox ID="txtNomeEstado" runat="server"></asp:TextBox>
          <label for="txtNomeEstado">Nome do estado</label>
      </div>

      <div class="input-field col s2">
          <asp:TextBox ID="txtSiglaEstado" runat="server"></asp:TextBox>
          <label for="txtSiglaEstado">Sigla</label>
      </div>

          <div class="input-field col s2">
    <asp:TextBox ID="txtCodigoPais" runat="server"></asp:TextBox>
    <label for="txtCodigoPais">Código do país</label>
</div>
  </div>
  <br />
  <br />
  <br />
  <br />
  <br />
  <asp:Button ID="btnSalvar" runat="server" BackColor="#1BBA2F" BorderStyle="None" ForeColor="White" Height="40px" Text="Salvar" Width="100px" OnClick="btnSalvar_Click"  />
  &nbsp;&nbsp;&nbsp;
<asp:Button ID="btnCancelar" runat="server" BackColor="#FF6262" BorderStyle="None" ForeColor="White" Height="40px" Text="Cancelar" Width="100px" OnClick="btnCancelar_Click"  />
</asp:Content>
