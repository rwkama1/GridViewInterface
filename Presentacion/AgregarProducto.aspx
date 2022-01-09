<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AgregarProducto.aspx.cs" Inherits="AgregarProducto" %>

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
                    Nombre:
                </td>
                <td>
                    <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox></td>
                <td style="width: 3px">
                </td>
            </tr>
            <tr>
                <td>
                    Precion:
                </td>
                <td>
                    <asp:TextBox ID="txtPrecio" runat="server"></asp:TextBox></td>
                <td style="width: 3px">
                </td>
            </tr>
        </table>
        <br />
        <br />
        &nbsp;<asp:Button ID="btnAgregar" runat="server" OnClick="btnAgregar_Click" Text="Agregar" />
        <asp:Label ID="lblError" runat="server"></asp:Label><br />
        &nbsp;
        <asp:FileUpload ID="flpAgregaFotoChica" runat="server" />
        <asp:Image ID="imgFotoChica" runat="server" /><br />
        <br />
        &nbsp;<asp:FileUpload ID="flpAgregaFotoGrande" runat="server" />
        <asp:Image ID="imgFotoGrande" runat="server" /><br />
        <br />
        <br />
        <br />
        &nbsp;<br />
        <br />
        <br />
    </div>
    </form>
</body>
</html>
