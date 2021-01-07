<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewSalesBetweenTwoDatesUI.aspx.cs" Inherits="StockManagementWebApp.UI.ViewSalesBetweenTwoDatesUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 216px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h3>View Sales Between Two Dates</h3>
        <asp:HyperLink  runat="server" NavigateUrl="IndexUI.aspx">Home</asp:HyperLink><br/>
        <asp:HyperLink  runat="server" NavigateUrl="CategoryUI.aspx">Catagory Setup</asp:HyperLink> <br/>
         <asp:HyperLink  runat="server" NavigateUrl="CompanyUI.aspx">Company Setup</asp:HyperLink> <br/>
        <asp:HyperLink  runat="server" NavigateUrl="ItemUI.aspx">Item Setup</asp:HyperLink><br/>
         <asp:HyperLink  runat="server" NavigateUrl="StockInUI.aspx">Stock In</asp:HyperLink> <br/>
         <asp:HyperLink  runat="server" NavigateUrl="StockoutUI.aspx">Stock Out</asp:HyperLink><br/>         
         <asp:HyperLink  runat="server" NavigateUrl="SearchAndViewItemsUI.aspx">Search And View Items</asp:HyperLink>
   
    <table>
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="From Date"></asp:Label>
            </td>
            <td class="auto-style1">
                <asp:TextBox ID="fromDateTextBox" runat="server" TextMode="Date" Width="185px"></asp:TextBox>
            </td>
        </tr> 
        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="To Date"></asp:Label>
            </td>
            <td class="auto-style1">
                <asp:TextBox ID="toDateTextBox" runat="server" TextMode="Date" Width="182px"></asp:TextBox>
            </td>
        </tr>
       <tr>
           <td>
               <asp:Button ID="searchButton" runat="server" Text="Search" OnClick="searchButton_Click" />
               
           </td>
           <td>
               <asp:Label ID="OutputLabel" runat="server"></asp:Label>
           </td>
       </tr>
    </table>
        <asp:GridView ID="viewSalesGridView" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3">
            
          <Columns>
                  <asp:TemplateField HeaderText="Sl">
                     <ItemTemplate>
                         <asp:Label runat="server" Text='<%#Container.DataItemIndex+1 %>'>'></asp:Label>
                        <asp:HiddenField ID="idHiddenField" runat="server" Value='<% #Eval("Id")%>'/>
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
