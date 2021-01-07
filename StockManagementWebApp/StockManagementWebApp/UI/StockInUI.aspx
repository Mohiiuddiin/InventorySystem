<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StockInUI.aspx.cs" Inherits="StockManagementWebApp.UI.StockInUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
         <h3>Stock In</h3> 
        <asp:HyperLink  runat="server" NavigateUrl="IndexUI.aspx">Home</asp:HyperLink> <br/>
        <asp:HyperLink  runat="server" NavigateUrl="CategoryUI.aspx">Catagory Setup</asp:HyperLink> <br/>
         <asp:HyperLink  runat="server" NavigateUrl="CompanyUI.aspx">Company Setup</asp:HyperLink> <br/>
        <asp:HyperLink  runat="server" NavigateUrl="ItemUI.aspx">Item Setup</asp:HyperLink><br/>
         
         <asp:HyperLink  runat="server" NavigateUrl="StockoutUI.aspx">Stock Out</asp:HyperLink><br/>

         <asp:HyperLink  runat="server" NavigateUrl="ViewSalesBetweenTwoDatesUI.aspx">View Sales Between Two Dates</asp:HyperLink> <br/>
         <asp:HyperLink  runat="server" NavigateUrl="SearchAndViewItemsUI.aspx">Search And View Items</asp:HyperLink>
   
    <table>
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Company"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="companyDropDownList"  runat="server"  onselectedindexchanged="CompanyValueSelectedIndexChanged" 
            AutoPostBack="True" BackColor="#669999"></asp:DropDownList> 
                </td>
            </tr>
         <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Item"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="itemDropDownList" runat="server"  BackColor="#669999" OnSelectedIndexChanged="itemDropDownList_SelectedIndexChanged" AutoPostBack="True"></asp:DropDownList> 
                </td>
            </tr>
        
         <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="Reorder Level"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="reorderLevelTextBox" runat="server" BackColor="#99CCFF" Enabled="False"></asp:TextBox>
                </td>
            </tr>
        
         <tr>
                <td>
                    <asp:Label ID="Label4" runat="server" Text="Available Quantity"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="availabelQuantityTextBox" runat="server" BackColor="#99CCFF" Enabled="False"></asp:TextBox>
                </td>
            </tr>
         <tr>
                <td>
                    <asp:Label ID="Label5" runat="server" Text="Stock In Quantity"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="stockInquantityTextBox" runat="server" BackColor="#CCCCCC"></asp:TextBox>
                </td>
            </tr>
        
        <tr>
                <td>
                    <asp:Button ID="saveButton" runat="server" Text="Save" OnClick="saveButton_Click" />
                </td>
              <td>
                  <asp:Label ID="outputLabel" runat="server"></asp:Label>
              </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
