<%@ Page Title="" Language="C#" MasterPageFile="~/Navbar.Master" AutoEventWireup="true" CodeBehind="Gestionale.aspx.cs" Inherits="WebApplication5.Gestionale" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Content/Site.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
       

        <div class="mt-5">
            <div class="container-fluid w-50 d-flex justify-content-between mt-5">
            </div>

            <div class="container mt-5">
                <div class="mb-5">

                    <h1>Gestione Dipendenti </h1>
                    <span>Nuovo dipendente?   <a class=" text-decoration-none " href="AddDipendente.aspx">Crea Dipendente</a>  </span>
                </div>
                <table class="table  table-striped shadowTable">

                    <thead>
                        <tr>
                            <th>Nome</th>
                            <th>Cognome</th>
                            <th>Indirizzo</th>
                            <th>Codice Fiscale</th>
                            <th>Coniugato</th>
                            <th>Numero Figli</th>
                            <th>Mansione</th>
                            <th></th>
                            <th></th>
                        </tr>
                    </thead>
                    <tbody>
                        <asp:Repeater ID="repeaterDipendenti" runat="server">
                            <ItemTemplate>
                                <tr>
                                    <td><%# Eval("Nome") %></td>
                                    <td><%# Eval("Cognome") %></td>
                                    <td><%# Eval("Indirizzo") %></td>
                                    <td><%# Eval("CodiceFiscale") %></td>
                                    <td><%# Eval("Coniugato") %></td>
                                    <td><%# Eval("NumeroFigli") %></td>
                                    <td><%# Eval("Mansione") %></td>
                                    <td>
                                        <a href='<%# $"Pagamento.aspx?ID={Eval("Id")}" %>' class="btn btn-success btn-sm">Pagamento</a>
                                    </td>
                                    <td>
                                        <a href='<%# $"Storico.aspx?ID={Eval("Id")}" %>' class="btn btn-info btn-sm">Storico</a>
                                    </td>

                                </tr>
                            </ItemTemplate>
                        </asp:Repeater>
                    </tbody>
                </table>
            </div>

        </div>

</asp:Content>
