<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TeacherForm.aspx.cs" Inherits="wt1.TeacherForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>


        body {
            font-family: Arial, sans-serif;
            background-color: #f4f4f4;
            margin: 0;
            padding: 0;
        }
        .container {
            max-width: 800px;
            margin: 20px auto;
            background-color: #fff;
            padding: 20px;
            border-radius: 5px;
            box-shadow: 0 2px 5px rgba(0, 0, 0, 0.1);
        }
        h1 {
            text-align: left;
            color: #333;
        }
        table {
            width: 50%;
            border-collapse: collapse;
            margin-bottom: 20px;
        }
        table tr {
            border-bottom: 1px solid #ccc;
        }
        table td {
            padding: 5px;
        }
        .button-container {
            text-align: center;
            margin-bottom: 20px;
        }
        .status-label {
            color: green;
        }
        .data-grid-container {
            margin-top: 20px;
        }
        .auto-style1 {
            width: 497px;
            height: 45px;
        }
        .auto-style2 {
            width: 497px;
        }
        .auto-style6 {
            width: 11px;
        }
        .auto-style7 {
            height: 45px;
            width: 11px;
        }
        .auto-style8 {
            width: 389px;
            height: 27px;
        }
    </style>
</head>
<body>
      <form id="form1" runat="server">

          <div class="navbar">
                <asp:Button ID="student" Text="Car details" runat="server" OnClick="st" CssClass="nav-button" />
                <asp:Button ID="subject" Text="User details" runat="server" OnClick="sb" CssClass="nav-button" />
          </div>

          <div>
            <h1>Purchase Form</h1>
        </div>
        <div>
            <table>
                <tr>
                    <td class="auto-style6"> <asp:Label ID="purchaseIDLabel" runat="server" Text="Purchase ID"> </asp:Label></td>
                    <td class="auto-style2"> <asp:TextBox ID="pid" runat="server" Width="259px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="auto-style6"> <asp:Label ID="userIDLabel" runat="server" Text="User ID"> </asp:Label></td>
                    <td class="auto-style2"> <asp:TextBox ID="userID" runat="server" Width="255px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="auto-style7"> <asp:Label ID="carIDLabel" runat="server" Text="Car ID"> </asp:Label></td>
                    <td class="auto-style1"> <asp:TextBox ID="carID" runat="server" Width="254px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="auto-style6"> <asp:Label ID="purchaseDateLabel" runat="server" Text="Purchase Date"> </asp:Label></td>
                    <td class="auto-style2"> <asp:TextBox ID="purchaseDate" runat="server" Width="255px"></asp:TextBox></td></td>
                </tr>
            </table>

            <table>
                <tr>
                    <td class="auto-style2"><asp:Button ID="sinsert" Text="Insert" runat="server" OnClick="t_inserted" /> </td>
                    <td class="auto-style2"><asp:Button ID="supdate" Text="Update" runat="server" OnClick="t_updated" /> </td>
                    <td class="auto-style2"><asp:Button ID="sdelete" Text="Delete" runat="server" OnClick="t_deleted" /> </td>
                    <td class="auto-style2"><asp:Button ID="sread" Text="Read" runat="server" OnClick="t_read" /> </td>
                    <td class="auto-style2"><asp:Button ID="sall" Text="Read All" runat="server" OnClick="t_all" /> </td>
                    <td>Status: <asp:Label ID="status" runat="server"> </asp:Label><br /></td>
                </tr>
            </table>
        </div>
        <div>
            
        </div>
        <div>
            <asp:DataGrid ID="s_grid" runat="server"></asp:DataGrid>
        </div>
    </form>
</body>
</html>
