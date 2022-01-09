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

using System.IO;


public partial class AgregarProducto : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnAgregar_Click(object sender, EventArgs e)
    {
        
        //Obtenemos la ruta donde el archivo se va a guardar en el servidor
        string oNombreArchivoFotoChica=flpAgregaFotoChica.PostedFile.FileName;
        string oRutaCompletaFotoChica = Server.MapPath("") + "\\Imagenes\\" + oNombreArchivoFotoChica;
        //y por ultimo se salva el archivo a el servidor 
        flpAgregaFotoChica.PostedFile.SaveAs(oRutaCompletaFotoChica);
        imgFotoChica.ImageUrl = "~/Imagenes/" +oNombreArchivoFotoChica;
        lblError.Text = "Tu archivo se recibio correctamente en:: <br/> <b>" + oRutaCompletaFotoChica + "</b>";


        string oNombreArchivoFotoGrande = flpAgregaFotoGrande.PostedFile.FileName;
        string oRutaCompletaFotoGrande = Server.MapPath("") + "\\Imagenes\\" + oNombreArchivoFotoGrande;
        //y por ultimo se salva el archivo a el servidor 
        flpAgregaFotoGrande.PostedFile.SaveAs(oRutaCompletaFotoGrande);
        imgFotoGrande.ImageUrl = "~/Imagenes/" + oNombreArchivoFotoGrande;
        lblError.Text = "Tu archivo se recibio correctamente en:: <br/> <b>" + oRutaCompletaFotoGrande + "</b>";


        Producto p = new Producto(0, "~/Imagenes/" + oNombreArchivoFotoChica, "~/Imagenes/" + oNombreArchivoFotoGrande, txtNombre.Text, Convert.ToDouble(txtPrecio.Text), true);
        int oResultado = DatosProductos.Agregar(p);//debería  ser LogicaProductos.Agregar(p);
        if (oResultado==-1)
        {
            lblError.Text = "El nombre del libro esta repetido";
        }
        else
        {
            lblError.Text = "Se agrego el libro con codigo: " + oResultado;
        }
    }
}
