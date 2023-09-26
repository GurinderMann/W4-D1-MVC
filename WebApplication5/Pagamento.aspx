<%@ Page Title="" Language="C#" MasterPageFile="~/Navbar.Master" AutoEventWireup="true" CodeBehind="Pagamento.aspx.cs" Inherits="WebApplication5.Pagamento" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="container-fluid justify-content-center align-items-center mx-auto w-50 mt-5">
     <div class=" container w-50">
         <h1>Aggiungi Pagamento</h1>
         <div class="form-group">
             <label for="DataPagamento">Data Pagamento:</label>
             <asp:TextBox ID="DataPagamento" runat="server" CssClass="form-control "></asp:TextBox>
             <asp:RequiredFieldValidator ID="rfvDataPagamento" runat="server" ControlToValidate="DataPagamento" InitialValue="" ErrorMessage="Campo obbligatorio" Display="Dynamic" ForeColor="Red"></asp:RequiredFieldValidator>
         </div>

         <div class="form-group">
             <label for="Ammontare">Ammontare:</label>
             <asp:TextBox ID="Ammontare" runat="server" CssClass="form-control"></asp:TextBox>
             <asp:RequiredFieldValidator ID="rfvAmmontare" runat="server" ControlToValidate="Ammontare" InitialValue="" ErrorMessage="Campo obbligatorio" Display="Dynamic" ForeColor="Red"></asp:RequiredFieldValidator>
         </div>

         <div class="form-group">
             <label for="Tipo">Tipo Pagamento:</label>
             <asp:DropDownList ID="PagamentoDropDown" runat="server" CssClass="form-control">
                 <asp:ListItem Text="Seleziona un tipo" Value="" />
                 <asp:ListItem Text="Stipendio" Value="Stipendio" />
                 <asp:ListItem Text="Acconto" Value="Acconto" />
             </asp:DropDownList>
             <asp:RequiredFieldValidator ID="rfvTipoPagamento" runat="server" ControlToValidate="PagamentoDropDown" InitialValue="" ErrorMessage="Seleziona un tipo di pagamento" Display="Dynamic" ForeColor="Red"></asp:RequiredFieldValidator>
         </div>

      


         <asp:Button ID="Button1" runat="server" CssClass="btn btn-info text-light mt-3" Text="Salva" OnClick="Button1_Click" />
         <asp:Label ID="Label1" runat="server"></asp:Label>
         <asp:Label ID="Label2" runat="server"></asp:Label>
     </div>
 </div>
</asp:Content>
