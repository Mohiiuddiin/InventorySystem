<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CatagoryUpdateUI.aspx.cs" Inherits="StockManagementWebApp.UI.CatagoryUpdateUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
         <h3>Category Update</h3> 
        <table>
    
             <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
                    <asp:HiddenField ID="idHiddenField" runat="server"/>
                </td>
                <td>
                    <asp:TextBox ID="nameTextBox" runat="server" Width="97px"></asp:TextBox> 
                </td>
            </tr>
          <tr>
              <td>
                    <asp:Button ID="updateButton" runat="server" text="Update" width="73px" OnClick="updateButton_Click"   />
              </td>
              <td>
                   <asp:Label ID="outputLabel" runat="server" Text=""></asp:Label>
              </td>
          </tr>
            </table>
    </div>
    </form>
</body>
</html>
