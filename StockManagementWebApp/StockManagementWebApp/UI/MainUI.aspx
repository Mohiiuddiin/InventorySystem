<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainUI.aspx.cs"
    Inherits="StockManagementWebApp.UI.MainUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../Content/bootstrap.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <nav class="navbar navbar-expand-lg navbar-dark bg-dark">
            <a class="navbar-brand" href="#">Inventory</a>
            <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarColor02" aria-controls="navbarColor02" aria-expanded="false" aria-label="Toggle navigation">
                <span class="navbar-toggler-icon"></span>
            </button>
            <div class="collapse navbar-collapse" id="navbarColor02">
                <ul class="navbar-nav mr-auto">
                    <li class="nav-item active">
                        <a class="nav-link" href="#" >Home
                    <span class="sr-only">(current)</span>
                        </a>
                    </li>
                    <li class="nav-item dropdown">
                        <a class="nav-link dropdown-toggle" data-toggle="dropdown" href="#" role="button" aria-haspopup="true" aria-expanded="false">Category</a>
                        <div class="dropdown-menu" style="background-color: black">
                            <a class="dropdown-item bg-dark" href="CategoryUI.aspx" style="font-weight: bold; color: azure;">Add New Category</a>
                        </div>
                    </li>
                    <li class="nav-item dropdown">
                        <a class="nav-link dropdown-toggle" data-toggle="dropdown" href="#" role="button" aria-haspopup="true" aria-expanded="false">Company</a>
                        <div class="dropdown-menu">
                            <a class="dropdown-item bg-dark" href="CompanyUI.aspx" style="font-weight: bold; color: azure;">Add New Company</a>
                        </div>
                    </li>
                    <li class="nav-item dropdown">
                        <a class="nav-link dropdown-toggle" data-toggle="dropdown" href="#" role="button" aria-haspopup="true" aria-expanded="false">Item</a>
                        <div class="dropdown-menu">
                            <a class="dropdown-item bg-dark" href="ItemUI.aspx" style="font-weight: bold; color: azure;">Add New Item</a>
                        </div>
                    </li>
                    <li class="nav-item dropdown">
                        <a class="nav-link dropdown-toggle" data-toggle="dropdown" href="#" role="button" aria-haspopup="true" aria-expanded="false">Stock Management</a>
                        <div class="dropdown-menu">
                            <a class="dropdown-item bg-dark" href="StockInUI.aspx" style="font-weight: bold; color: azure;">Stock In</a>
                            <div class="dropdown-divider"></div>
                            <a class="dropdown-item bg-dark" href="StockoutUI.aspx" style="font-weight: bold; color: azure;">Stock Out</a>
                            <div class="dropdown-divider"></div>
                            <a class="dropdown-item bg-dark" href="SearchAndViewItemsUI.aspx" style="font-weight: bold; color: azure;">Search And View Items</a>
                        </div>
                    </li>
                    <li class="nav-item dropdown">
                        <a class="nav-link dropdown-toggle" data-toggle="dropdown" href="#" role="button" aria-haspopup="true" aria-expanded="false">Sales Report</a>
                        <div class="dropdown-menu">
                            <a class="dropdown-item bg-dark" href="ViewSalesBetweenTwoDatesUI.aspx" style="font-weight: bold; color: azure;">View Sales Between Two Dates</a>
                        </div>
                    </li>
                   
                </ul>

            </div>
        </nav>

        <div>
        </div>
    </form>
    <script src="../Scripts/jquery-3.0.0.js"></script>
    <script src="../Scripts/bootstrap.js"></script>
    <script src="../Scripts/bootstrap.bundle.js"></script>
</body>
</html>
