<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadastroCidade.aspx.cs" Inherits="WebApplication1.CadastroCidade" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <script>
        document.addEventListener('DOMContentLoaded', function () {
            var elems = document.querySelectorAll('select');
            M.FormSelect.init(elems);
        });


    </script>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="row">
        <div class="input-field col s2">            
            <asp:TextBox ID="txtCodigoCidade" runat="server"></asp:TextBox>
            <label for="txtCodigoCidade">Código da cidade</label>
        </div>
        <div class="input-field col s5">            
            <asp:TextBox ID="txtNomeCidade" runat="server"></asp:TextBox>
            <label for="txtNomeCidade">Nome da cidade</label>
        </div>
        <div class="input-field col s2">
            
            <asp:TextBox ID="txtCodigoIbge" runat="server"></asp:TextBox>
            <label for="txtCodigoIbge">Código IBGE</label>
        </div>

        <div class="input-field col s1">
            <asp:TextBox ID="txtDdd" runat="server"></asp:TextBox>
            <label for="txtDdd">DDD</label>
        </div>

        <div class="input-field col s4">
            <asp:DropDownList ID="cbbEstados" runat="server"></asp:DropDownList>
          <%--    <select id="cbbEstados" runat="server">
                <option value="0" disabled selected>Escolha o estado</option>                
            <%--<option value="1">Option 1</option>
            <option value="2">Option 2</option>
            <option value="3">Option 3</option>
            </select>--%>
            <label>Estado</label>
        </div>
    </div>
    <br />
    <br />
    <br />
    <br />
    <br />
    <asp:Button ID="btnSalvar" runat="server" BackColor="#1BBA2F" BorderStyle="None" ForeColor="White" Height="40px" Text="Salvar" Width="100px" OnClick="btnSalvar_Click" />
    &nbsp;&nbsp;&nbsp;
     <asp:Button ID="btnCancelar" runat="server" BackColor="#FF6262" BorderStyle="None" ForeColor="White" Height="40px" Text="Cancelar" Width="100px" OnClick="btnCancelar_Click" />


</asp:Content>
