<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Category.aspx.cs" Inherits="inventory_management_system.Category" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
         <h1> add category</h1>
        <div class="form-group">
        <asp:Label ID="lblName"  runat="server"> name</asp:Label>
        <asp:textbox ID="txtName" class="form-control" runat="server" ></asp:textbox>
        </div>

        <div class="form-group">
        <asp:Label ID="lblCode"  runat="server">code</asp:Label>
        <asp:textbox ID="txtCode" class="form-control" runat="server"></asp:textbox>

             <asp:Button ID="btnSubmit" runat="server"  class="btn btn-primary"  Text="submit" OnClick="btnSubmit_Click"/>
        </div>
    </div>



    <div>
            <asp:GridView ID="gridCategory" runat="server" OnSelectedIndexChanged="gridCategory_SelectedIndexChanged">
                
            </asp:GridView>

    </div>
</asp:Content>
