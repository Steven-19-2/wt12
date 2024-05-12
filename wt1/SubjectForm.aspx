<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SubjectForm.aspx.cs" Inherits="wt1.SubjectForm" %>

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

        <div>
            <table>
                <tr>
                    <td class="auto-style2"><asp:Button ID="teacher" Text="Purchase" runat="server" OnClick="ts" /> </td>
                    <td class="auto-style2"><asp:Button ID="student" Text="Car details" runat="server" OnClick="st" /> </td>
                   
                </tr>
            </table>
        </div>

        <div>
            <h1>User Form</h1>
        </div>
        <div>
            <table>
                <tr>
                    <td> <asp:Label ID="userIdLabel" runat="server" Text="User ID"> </asp:Label></td>
                    <td> <asp:TextBox ID="userId" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td> <asp:Label ID="usernameLabel" runat="server" Text="Username"> </asp:Label></td>
                    <td> <asp:TextBox ID="username" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="auto-style1"> <asp:Label ID="emailLabel" runat="server" Text="Email"> </asp:Label></td>
                    <td class="auto-style1"> <asp:TextBox ID="email" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td> <asp:Label ID="passwordLabel" runat="server" Text="Password"> </asp:Label></td>
                    <td> <asp:TextBox ID="password" runat="server" TextMode="Password"></asp:TextBox></td>
                </tr>
                <tr>
                    <td> <asp:Label ID="roleLabel" runat="server" Text="Role"> </asp:Label></td>
                    <td> <asp:TextBox ID="role" runat="server"></asp:TextBox></td>
                </tr>
            </table>

            <table>
                <tr>
                    <td class="auto-style2"><asp:Button ID="sinsert" Text="Insert" runat="server" OnClick="s_inserted" /> </td>
                    <td class="auto-style2"><asp:Button ID="supdate" Text="Update" runat="server" OnClick="s_updated" /> </td>
                    <td class="auto-style2"><asp:Button ID="sdelete" Text="Delete" runat="server" OnClick="s_deleted" /> </td>
                    <td class="auto-style2"><asp:Button ID="sread" Text="Read" runat="server" OnClick="s_read" /> </td>
                    <td class="auto-style2"><asp:Button ID="sall" Text="Read All" runat="server" OnClick="s_all" /> </td>
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
