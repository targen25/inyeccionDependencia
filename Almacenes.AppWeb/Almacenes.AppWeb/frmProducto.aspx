<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmProducto.aspx.cs" Inherits="Almacenes.AppWeb.frmProducto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>Producto ID </td>
                    <td><asp:TextBox ID="txProductoId" runat="server"></asp:TextBox> </td>
                    
                </tr>
                <tr>
                    <td> Nombre</td>
                    <td><asp:TextBox ID="txNombre" runat="server"></asp:TextBox> </td>
                </tr>
                <tr>
                    <asp:Label ID="laResultado" runat="server" Text="Label"></asp:Label>

                </tr>
            </table>
            <asp:Button ID="buSave" runat="server" Text="Save" OnClick="buSave_Click" />
        </div>
    </form>
</body>
</html>
