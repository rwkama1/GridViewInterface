using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class MostrarProducto : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session[ConstantesSession.ProdSeleccionado] != null)
        {
            int id = (int)Session[ConstantesSession.ProdSeleccionado];
            Producto p = DatosProductos.Buscar(id);
            txtId.Text = p.IdProducto.ToString();
            txtNombre.Text = p.Nombre;
            txtPrecio.Text = p.Precio.ToString();
            chcEntregaInmediata.Checked = p.EntregaInmediata;
            imgFotoGrande.ImageUrl = p.FotoGrande;
        }
    }
}
