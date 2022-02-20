<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="users.aspx.cs" Inherits="inventory_management_system.users" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

     <div  >
        <h1> add user</h1>
        <div class="form-group">
        <asp:Label ID="lblFullname"  runat="server"> full name</asp:Label>
        <asp:textbox ID="txtFullName" class="form-control" runat="server" OnTextChanged="txtFullName_TextChanged"></asp:textbox>
        </div>

        <div class="form-group">
        <asp:Label ID="lblLoginName"  runat="server">login name</asp:Label>
        <asp:textbox ID="txtLoginName" class="form-control" runat="server"></asp:textbox>
        </div>

         <div class="form-group">
        <asp:Label ID="lblEmail"  runat="server">email</asp:Label>
        <asp:textbox ID="txtEmail" class="form-control" runat="server" TextMode="Email"></asp:textbox>
        </div>

         <div class="form-group">
        <asp:Label ID="lblPhone"  runat="server">phone </asp:Label>
        <asp:textbox ID="txtPhone" class="form-control" runat="server"></asp:textbox>
        </div>

         <div class="form-group">
        <asp:Label ID="lblAddress"  runat="server">address</asp:Label>
        <asp:textbox ID="txtAddress" class="form-control" runat="server"></asp:textbox>
        </div>

         <div class="form-group">
        <asp:Label ID="lblPassword"  runat="server">password</asp:Label>
        <asp:textbox ID="txtPassword" class="form-control" runat="server" TextMode="Password"></asp:textbox>
        </div>

         

        <div>
            <asp:Button ID="btnSubmit" runat="server"  class="btn btn-primary"  Text="submit" OnClick="btnSubmit_Click"/>
        <a href="register.aspx" style="margin-left:25px;"> need to register? click me</a>
            </div>

         <asp:Label ID="lblconfirm" runat="server" Visible="false"> </asp:Label>
        </div>

    <div id="panel" style="height: 500px; background-color: White; padding: 10px; overflow: auto" >

        <asp:GridView ID="gridUsers" runat="server"  class="gv"></asp:GridView>
    </div>
</asp:Content>
