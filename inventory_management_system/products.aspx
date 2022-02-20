<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="products.aspx.cs" Inherits="inventory_management_system.products" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div >
        <h1> add product</h1>
        <div class="form-group">
        <Label id="lblname"  > name</Label>
        <input type="text" id="txtName" class="form-control" />
        </div>

        <div class="form-group">
        <Label ID="lblcode"  >categoryID</Label>
            <input type="text" id="txtCategoryID" class="form-control" />
        </div>

         <div class="form-group">
        <Label ID="lblPurchasePrice"  >purchase price</Label>
        <input type="text" id="txtPurchasePrice" class="form-control" / >
        </div>

         <div class="form-group">
        <Label ID="description"  >description</Label>
        <input type="text" id="txtDescription" class="form-control"  TextMode="MultiLine" />
        </div>

         <div class="form-group">
        <Label ID="lblSalesPrice"  >seliing price</Label>
        <input type="text" id="txtSalesPrice" class="form-control" / >
        </div>

         <div class="form-group">
        <Label ID="lblCode" >code</Label>
        <input type="text" id="txtode" class="form-control" />
        </div>

        <div>
            <Button id="btnSubmit"   class="btn btn-primary"  Text="submit"> submit</button>
        <a href="register.aspx" style="margin-left:25px;"> need to register? click me</a>
            </div>


        </div>
    <br />
    <br />
    <%--<asp:GridView ID="GridProducts" runat="server"></asp:GridView>--%>



    
    <script src="Scripts/jquery-3.4.1.js"></script>
    <script src="Scripts/jquery-3.4.1.min.js"></script>

    <script src="Scripts/jquery-3.4.1.slim.js"></script>
    <script src="Scripts/jquery-3.4.1.slim.min.js"></script>
    <script src="Scripts/modernizr-2.8.3.js"></script>
    <script>
        //const { post } = require("jquery")
        //debugger;
        $("#btnSubmit").click(function () {
            alert("a product needs name")
            debugger;
            var name = $("txtName").val();
            //if (!name) {
            //    alert("a product needs name");
            //}
            var categoryID = $("txtCategoryID").val();
            var purchasePrice = $("txtPurchasePrice").val();
            var salesPrice = $("txtSalesPrice").val();
            var description = $("txtDescription").val();
            var Code = $("txtCode").val();
            alert("initialzation finish");
            debugger;
            $.ajax({
                url: "api/product/insert",
                type: "POST",
                data: "{products:{ Name: '" + name + "', CategoryID: '" + categoryID + "', PurchasePrice: '" + purchasePrice + "', SalesPrice: '" + salesPrice + "', Description: '" + description + "', Code: '" + Code + "'}}",            //    data: JSON.stringify({ Name: $("#txtname").val, ContentID: $("txtCategoryID").val, Code: $("#txtCode").val, PurchasePrice: $("txtPurchasePrice").val, description: $("txtDescription").val, SalesPrice: $("txtSalesPrice").val }),
                contentType: "application/json; charset=utf-8",
                dataType: "JSON",
                
                success: function (data) {
                    alert("ajax call finisg");
                }

             })
        })
    </script>
</asp:Content>
