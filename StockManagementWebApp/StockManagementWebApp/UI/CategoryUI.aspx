<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CategoryUI.aspx.cs" Inherits="StockManagementWebApp.UI.CategoryUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h3>Category Setup</h3>
        <asp:HyperLink  runat="server" NavigateUrl="IndexUI.aspx">Home</asp:HyperLink> <br/>
         <asp:HyperLink  runat="server" NavigateUrl="CompanyUI.aspx">Company Setup</asp:HyperLink> <br/>
        <asp:HyperLink  runat="server" NavigateUrl="ItemUI.aspx">Item Setup</asp:HyperLink><br/>
         <asp:HyperLink  runat="server" NavigateUrl="StockInUI.aspx">Stock In</asp:HyperLink> <br/>
         <asp:HyperLink  runat="server" NavigateUrl="StockoutUI.aspx">Stock Out</asp:HyperLink><br/>

         <asp:HyperLink  runat="server" NavigateUrl="ViewSalesBetweenTwoDatesUI.aspx">View Sales Between Two Dates</asp:HyperLink> <br/>
         <asp:HyperLink  runat="server" NavigateUrl="SearchAndViewItemsUI.aspx">Search And View Items</asp:HyperLink>
        <table>
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="nameTextBox" runat="server"></asp:TextBox> 
                </td>
            </tr> 
            <tr>
                <td>
                            <asp:Button ID="Button1" runat="server" Text="Save" Width="43px" OnClick="saveButton_Click" />

                </td>
                <td>
                            <asp:Label ID="outputLabel" runat="server" Text=""></asp:Label>

                </td>
            </tr>
        </table>
        
    
       
    
        <br />
         <asp:GridView ID="categoryGridView" runat="server" AutoGenerateColumns="False">
             <Columns>
                  <asp:TemplateField HeaderText="Sl">
                     <ItemTemplate>
                         <asp:Label runat="server" Text='<%#Container.DataItemIndex+1 %>'>'></asp:Label>
                        <asp:HiddenField ID="idHiddenField" runat="server" Value='<% #Eval("Id")%>'/>
                     </ItemTemplate>
                 </asp:TemplateField>

                 <asp:TemplateField HeaderText="Name">
                     <ItemTemplate>
                         <asp:Label runat="server" Text='<%#Eval("Name") %>'>'></asp:Label>
                     </ItemTemplate>
                 </asp:TemplateField>
                  <asp:TemplateField HeaderText="Acton">
                     <ItemTemplate>
                         <asp:LinkButton runat="server" OnClick="updateLinkButton_Click">Update</asp:LinkButton>
                         <asp:LinkButton runat="server" OnClick="deleteLinkButton_Click">Delete</asp:LinkButton>
                     </ItemTemplate>
                 </asp:TemplateField>

             </Columns>
        </asp:GridView>
        
        


    </div>
       
       
    </form>
</body>
</html>
