<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ItemUpdateUI.aspx.cs" Inherits="StockManagementWebApp.UI.ItemUpdateUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
         <h3>Item Update</h3> 
    <table>
            <tr>
                 <td>
                    <asp:Label ID="Label3" runat="server" Text="Category"></asp:Label>
                </td>
                <td>
                <asp:DropDownList ID="categoryDropDownList" runat="server"></asp:DropDownList>
                </td>
            </tr>
            
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Company"></asp:Label>
                </td>
                <td>
                <asp:DropDownList ID="companyDropDownList" runat="server"></asp:DropDownList>

                </td>

            </tr>
            
              <tr>
                <td >
                    <asp:Label ID="Label1" runat="server" Text="Item Name"></asp:Label>
                     
                </td>
                <td>
                    
                    <asp:TextBox ID="itemNameTextBox" runat="server"></asp:TextBox>
                    
                </td>

            </tr>
            
              <tr>
                <td>
                    <asp:Label ID="Label4" runat="server" Text="Reorder Level"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="reorderLevelTextBox" runat="server"></asp:TextBox>
                </td>

            </tr>
            <tr>
                <td>
                      <asp:Button ID="updateButton" runat="server" Text="Update" OnClick="updateButton_Click"  />
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
