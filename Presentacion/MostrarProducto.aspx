<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MostrarProducto.aspx.cs" Inherits="MostrarProducto" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Página sin título</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table>
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Id"></asp:Label></td>
                <td>
                    <asp:TextBox ID="txtId" runat="server"></asp:TextBox></td>
                <td style="width: 3px">
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Nombre"></asp:Label></td>
                <td>
                    <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox></td>
                <td style="width: 3px">
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="Precio"></asp:Label></td>
                <td>
                    <asp:TextBox ID="txtPrecio" runat="server"></asp:TextBox></td>
                <td style="width: 3px">
                </td>
            </tr>
            <tr>
                <td>
                    Disponible</td>
                <td>
                    <asp:CheckBox ID="chcEntregaInmediata" runat="server" /></td>
                <td style="width: 3px">
                </td>
            </tr>
        </table>
        <br />
        <asp:Image ID="imgFotoGrande" runat="server" /><br />
        <br />
    
    </div>
    </form>
</body>
</html>
