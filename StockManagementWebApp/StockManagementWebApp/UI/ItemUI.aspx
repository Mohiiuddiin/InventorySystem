<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ItemUI.aspx.cs" Inherits="StockManagementWebApp.UI.ItemUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
         <h3>Item Setup</h3> 
         <asp:HyperLink  runat="server" NavigateUrl="IndexUI.aspx">Home</asp:HyperLink>    <br/>

             <asp:HyperLink  runat="server" NavigateUrl="CategoryUI.aspx">Catagory Setup</asp:HyperLink> <br/>
         <asp:HyperLink  runat="server" NavigateUrl="CompanyUI.aspx">Company Setup</asp:HyperLink> <br/>
       
         <asp:HyperLink  runat="server" NavigateUrl="StockInUI.aspx">Stock In</asp:HyperLink> <br/>
         <asp:HyperLink  runat="server" NavigateUrl="StockoutUI.aspx">Stock Out</asp:HyperLink><br/>

         <asp:HyperLink  runat="server" NavigateUrl="ViewSalesBetweenTwoDatesUI.aspx">View Sales Between Two Dates</asp:HyperLink> <br/>
         <asp:HyperLink  runat="server" NavigateUrl="SearchAndViewItemsUI.aspx">Search And View Items</asp:HyperLink>
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
                      <asp:Button ID="saveButton" runat="server" Text="Save" OnClick="saveButton_Click" />
                </td>
                <td>
                    <asp:Label ID="outputLevel" runat="server" Text=""></asp:Label>
                </td>
            </tr>
        </table>
        <asp:GridView ID="itemGridView" runat="server" AutoGenerateColumns="False">
             <Columns>
                  <asp:TemplateField HeaderText="Sl">
                     <ItemTemplate>
                         <asp:Label runat="server" Text='<%#Container.DataItemIndex+1 %>'>'></asp:Label>
                        <asp:HiddenField ID="idHiddenField" runat="server" Value='<% #Eval("ItemId")%>'/>
                     </ItemTemplate>
                 </asp:TemplateField>

                 <asp:TemplateField HeaderText="Category">
                     <ItemTemplate>
                         <asp:Label runat="server" Text='<%#Eval("CategoryName") %>'>'></asp:Label>
                     </ItemTemplate>
                 </asp:TemplateField>
                 <asp:TemplateField HeaderText="Company">
                     <ItemTemplate>
                         <asp:Label runat="server" Text='<%#Eval("CompanyName") %>'>'></asp:Label>
                     </ItemTemplate>
                 </asp:TemplateField>
                 <asp:TemplateField HeaderText="Item Name">
                     <ItemTemplate>
                         <asp:Label runat="server" Text='<%#Eval("ItemName") %>'>'></asp:Label>
                     </ItemTemplate>
                     
                 </asp:TemplateField>
                      <asp:TemplateField HeaderText="Reorder Level">
                     <ItemTemplate>
                         <asp:Label runat="server" Text='<%#Eval("ReorderLevel") %>'>'></asp:Label>
                     </ItemTemplate>

                 </asp:TemplateField>
                  <asp:TemplateField HeaderText="Action">
                     <ItemTemplate>
                         <asp:LinkButton runat="server"  OnClick="updateLinkButton_Click" >Update</asp:LinkButton>
                         <asp:LinkButton runat="server" OnClick="deleteLinkButton_Click" >Delete</asp:LinkButton>
                     </ItemTemplate>
                 </asp:TemplateField>

             </Columns>
        </asp:GridView>
        
       
          
        

    </div>
    </form>
</body>
</html>
