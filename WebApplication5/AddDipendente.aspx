<%@ Page Title="" Language="C#" MasterPageFile="~/Navbar.Master" AutoEventWireup="true" CodeBehind="AddDipendente.aspx.cs" Inherits="WebApplication5.AddDipendente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div class="container-fluid d-flex flex-column align-items-center justify-content-center mx-auto w-50 mt-5 shadowTable">
        <h1 class=" text-center">Aggiungi Dipendente</h1>





        <div class="form-group">
            <label for="Nome">Nome:</label>
            <asp:TextBox ID="Nome" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="Cognome">Cognome:</label>
            <asp:TextBox ID="Cognome" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="Indirizzo">Indirizzo:</label>
            <asp:TextBox ID="Indirizzo" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="CodiceFisc">Codice Fiscale:</label>
            <asp:TextBox ID="CodiceFisc" runat="server" CssClass="form-control"></asp:TextBox>
        </div>

        <div class="form-group">
            <label for="NumeroFigli">Numero Figli:</label>
            <asp:TextBox ID="NumeroFigli" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="Mansione">Mansione:</label>
            <asp:TextBox ID="Mansione" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="Coniugato">Coniugato:</label>
            <asp:DropDownList ID="ConiugatoDropDown" runat="server" CssClass="form-control">
                <asp:ListItem Text="Si" Value="true" />
                <asp:ListItem Text="No" Value="false" />
            </asp:DropDownList>
        </div>
        <asp:Button ID="Button1" runat="server" Text="Aggiungi Dipendente" OnClick="Button1_Click" CssClass="btn btn-primary mt-2 mb-5" />

    </div>
</asp:Content>
