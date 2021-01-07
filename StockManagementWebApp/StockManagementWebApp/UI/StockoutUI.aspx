<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StockoutUI.aspx.cs" Inherits="StockManagementWebApp.UI.StockoutUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
         <h3>Stock Out</h3> 
        <asp:HyperLink  runat="server" NavigateUrl="IndexUI.aspx">Home</asp:HyperLink>    <br/>
        <asp:HyperLink  runat="server" NavigateUrl="CategoryUI.aspx">Catagory Setup</asp:HyperLink> <br/>
         <asp:HyperLink  runat="server" NavigateUrl="CompanyUI.aspx">Company Setup</asp:HyperLink> <br/>
        <asp:HyperLink  runat="server" NavigateUrl="ItemUI.aspx">Item Setup</asp:HyperLink><br/>
         <asp:HyperLink  runat="server" NavigateUrl="StockInUI.aspx">Stock In</asp:HyperLink> <br/>
      

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
                    <asp:Label ID="Label5" runat="server" Text="Stock Out Quantity"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="stockOutquantityTextBox" runat="server" BackColor="#CCCCCC"></asp:TextBox>
                </td>
            </tr>
        
        <tr>
                <td>
                    <asp:Button ID="addButton" runat="server" Text="Add" OnClick="addButton_Click" Width="71px"  />
                </td>
              <td>
                  <asp:Label ID="outputLabel" runat="server"></asp:Label>
              </td>
            </tr>
        </table>
        
        <asp:GridView ID="stockoutItemsGridview" runat="server" AutoGenerateColumns="False" Width="710px" >
            <Columns>
                  <asp:TemplateField HeaderText="Sl">
                     <ItemTemplate>
                         <asp:Label runat="server" Text='<%#Container.DataItemIndex+1 %>'>'></asp:Label>
                     </ItemTemplate>
                 </asp:TemplateField>

                 <asp:TemplateField HeaderText="Item">
                     <ItemTemplate>
                         <asp:Label runat="server" Text='<%#Eval("ItemName") %>'>'></asp:Label>
                     </ItemTemplate>
                 </asp:TemplateField>
                <asp:TemplateField HeaderText="Company">
                     <ItemTemplate>
                         <asp:Label runat="server" Text='<%#Eval("CompanyName") %>'>'></asp:Label>
                     </ItemTemplate>
                 </asp:TemplateField>
                 
                <asp:TemplateField HeaderText="Sale Quantity">
                     <ItemTemplate>
                         <asp:Label runat="server" Text='<%#Eval("Quantity") %>'>'></asp:Label>
                     </ItemTemplate>
                 </asp:TemplateField>
                 

             </Columns>
          
        </asp:GridView>


   

        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="sellButton" runat="server" Text="Sell" Width="61px" OnClick="sellButton_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="damageButton" runat="server" Text="Damage" OnClick="damageButton_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="lostButton" runat="server" Text="Lost" Width="48px" OnClick="lostButton_Click" />
        <br />


   

    </div>
    </form>
</body>
</html>
