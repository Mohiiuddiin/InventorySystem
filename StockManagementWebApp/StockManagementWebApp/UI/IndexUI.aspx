<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="IndexUI.aspx.cs" Inherits="StockManagementWebApp.UI.IndexUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
         <h3>Home</h3> 
        <asp:HyperLink  runat="server" NavigateUrl="CategoryUI.aspx">Catagory Setup</asp:HyperLink> <br/>
         <asp:HyperLink  runat="server" NavigateUrl="CompanyUI.aspx">Company Setup</asp:HyperLink> <br/>
        <asp:HyperLink  runat="server" NavigateUrl="ItemUI.aspx">Item Setup</asp:HyperLink><br/>
         <asp:HyperLink  runat="server" NavigateUrl="StockInUI.aspx">Stock In</asp:HyperLink> <br/>
         <asp:HyperLink  runat="server" NavigateUrl="StockoutUI.aspx">Stock Out</asp:HyperLink><br/>

         <asp:HyperLink  runat="server" NavigateUrl="ViewSalesBetweenTwoDatesUI.aspx">View Sales Between Two Dates</asp:HyperLink> <br/>
         <asp:HyperLink  runat="server" NavigateUrl="SearchAndViewItemsUI.aspx">Search And View Items</asp:HyperLink>
    </div>
    </form>
</body>
</html>
