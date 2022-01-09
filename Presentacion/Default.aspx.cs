using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

using System.Collections.Generic;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            List<Producto> p = DatosProductos.Listar();
            //p.Sort();
            grdProducto.DataSource = p;
            grdProducto.DataBind();
            grdotra.DataSource = p;
            grdotra.DataBind();
        }
        catch (Exception oEx)
        {
            lblError.Text = oEx.Message;
        }
    }
    protected void grdProducto_SelectedIndexChanged(object sender, EventArgs e)
    {
            string sId = grdProducto.SelectedRow.Cells[0].Text;
            int oId = Convert.ToInt32(sId);
            Session[ConstantesSession.ProdSeleccionado] = oId;
            Response.Redirect("MostrarProducto.aspx");
    }
    protected void grdotra_SelectedIndexChanged(object sender, EventArgs e)
    {
        string sId = grdotra.SelectedRow.Cells[0].Text;
        int oId = Convert.ToInt32(sId);
        Session[ConstantesSession.ProdSeleccionado] = oId;
        Response.Redirect("MostrarProducto.aspx");
    }
}
