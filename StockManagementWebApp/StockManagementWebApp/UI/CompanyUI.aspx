<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CompanyUI.aspx.cs" Inherits="StockManagementWebApp.CompanyUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
         <h3>Company Setup</h3> 
        <asp:HyperLink  runat="server" NavigateUrl="IndexUI.aspx">Home</asp:HyperLink>    <br/>
        <asp:HyperLink  runat="server" NavigateUrl="CategoryUI.aspx">Catagory Setup</asp:HyperLink> <br/>
      
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
                    <asp:TextBox ID="nameTextBox" runat="server" Width="97px"></asp:TextBox> 
                </td>
            </tr> 
             <tr>
                 <td>
                      <asp:Button ID="saveButton" runat="server" text="Save" width="43px" onclick="saveButton_Click"  />

                 </td>
                 <td>
                                          <asp:Label ID="outputLabel" runat="server" Text=""></asp:Label>

                 </td>
             </tr>
             </table>
            
 
        <asp:GridView ID="companyGridView" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" Width="607px">
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
