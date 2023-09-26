<%@ Page Title="" Language="C#" MasterPageFile="~/Navbar.Master" AutoEventWireup="true" CodeBehind="Storico.aspx.cs" Inherits="WebApplication5.Storico1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
          <div>
            <div class="container mt-5">
           
                    <h1>Storico Pagamenti</h1>
                  
                
                
    <table class="table table-bordered">
        <thead>
            <tr>
                <th>Data Pagamento</th>
                <th>Ammontare</th>
                <th>Tipo </th>
                <th>Id Dipendente</th>
               
            </tr>
        </thead>
        <tbody>
            <asp:Repeater ID="repeaterStorico" runat="server">
                <ItemTemplate>
                    <tr>
                       <td><%# ((DateTime)Eval("DataPagamento")).ToString("dd/MM/yyyy") %></td>
                        <td><%# ((decimal)Eval("Ammontare")).ToString("C2") %></td>
                        <td><%# Eval("TipoPagamento") %></td>
                        <td><%# Eval("IdDipendente") %></td>
                        
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
</div>
      </div>
</asp:Content>
