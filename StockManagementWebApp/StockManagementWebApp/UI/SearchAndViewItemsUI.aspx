<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SearchAndViewItemsUI.aspx.cs" Inherits="StockManagementWebApp.UI.SearchAndViewItemsUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
         <h3>Search And View Items</h3> 
        <asp:HyperLink  runat="server" NavigateUrl="IndexUI.aspx">Home</asp:HyperLink>
        <asp:HyperLink  runat="server" NavigateUrl="CategoryUI.aspx">Catagory Setup</asp:HyperLink> <br/>
         <asp:HyperLink  runat="server" NavigateUrl="CompanyUI.aspx">Company Setup</asp:HyperLink> <br/>
        <asp:HyperLink  runat="server" NavigateUrl="ItemUI.aspx">Item Setup</asp:HyperLink><br/>
         <asp:HyperLink  runat="server" NavigateUrl="StockInUI.aspx">Stock In</asp:HyperLink> <br/>
         <asp:HyperLink  runat="server" NavigateUrl="StockoutUI.aspx">Stock Out</asp:HyperLink><br/>

         <asp:HyperLink  runat="server" NavigateUrl="ViewSalesBetweenTwoDatesUI.aspx">View Sales Between Two Dates</asp:HyperLink> <br/>

    <table>
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Company"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="companyDropdownList" runat="server"></asp:DropDownList>
            </td>
        </tr> 
          <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Category"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="categoryDropdownList" runat="server"></asp:DropDownList>
            </td>
        </tr> 
        <tr>
            <td>
                <asp:Button ID="searchButton" runat="server" Text="Search" OnClick="searchButton_Click" />
                
            </td>
        </tr>

    </table>
        <asp:GridView ID="itemsGridView" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3">
             <Columns>
                  <asp:TemplateField HeaderText="Sl">
                     <ItemTemplate>
                         <asp:Label runat="server" Text='<%#Container.DataItemIndex+1 %>'>'></asp:Label>
                        <asp:HiddenField ID="idHiddenField" runat="server" Value='<% #Eval("ItemId")%>'/>
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
                 
                <asp:TemplateField HeaderText="Quantity">
                     <ItemTemplate>
                         <asp:Label runat="server" Text='<%#Eval("Quantity") %>'>'></asp:Label>
                     </ItemTemplate>
                 </asp:TemplateField> 
                  <asp:TemplateField HeaderText="Reorder Level">
                     <ItemTemplate>
                         <asp:Label runat="server" Text='<%#Eval("ReorderLevel") %>'>'></asp:Label>
                     </ItemTemplate>
                 </asp:TemplateField> 

                 </Columns>

         

             <FooterStyle BackColor="White" ForeColor="#000066" />
             <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
             <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
             <RowStyle ForeColor="#000066" />
             <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
             <SortedAscendingCellStyle BackColor="#F1F1F1" />
             <SortedAscendingHeaderStyle BackColor="#007DBB" />
             <SortedDescendingCellStyle BackColor="#CAC9C9" />
             <SortedDescendingHeaderStyle BackColor="#00547E" />

         

        </asp:GridView>
    </div>
    </form>
</body>
</html>
