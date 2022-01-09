using System;
using System.Collections.Generic;
using System.Text;

using System.Configuration;

using System.Data;
using System.Data.SqlClient;

public class DatosProductos
{

    public static List<Producto> Listar()
    {
        int oIdProducto = 0;
        string oFotoChica = "", oFotoGrande = "", oNombre = "";
        bool oEntregaInmediata = true;
        double oPrecio = 0;
        List<Producto> oListaProducto = new List<Producto>();
        Producto p = null;

        SqlConnection oConexion = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexionLibreria"].ConnectionString);
        string oConsulta = "Exec ListarProductos";
        SqlCommand oComando = new SqlCommand(oConsulta, oConexion);
        SqlDataReader oReader;
        try
        {
            oConexion.Open();
            oReader = oComando.ExecuteReader();
            while (oReader.Read())
            {
                oIdProducto = (int)oReader["IdProducto"];
                oFotoChica = (string)oReader["FotoChica"];
                oFotoGrande = (string)oReader["FotoGrande"];
                oNombre = (string)oReader["Nombre"];
                oPrecio = (double)oReader["Precio"];
                oEntregaInmediata = (bool)oReader["EntregaInmediata"];
                p = new Producto(oIdProducto, oFotoChica, oFotoGrande, oNombre, oPrecio, oEntregaInmediata);
                oListaProducto.Add(p);
            }
            oListaProducto.Sort();
            return oListaProducto;
        }
        catch (Exception ex)
        {
            throw new ApplicationException("Problemas con la base de datos: " + ex.Message);
        }
        finally
        {
            oConexion.Close();
        }
    }

    public static Producto Buscar(int id)
    {
        int oIdProducto = 0;
        string oFotoChica = "", oFotoGrande = "", oNombre = "";
        double oPrecio = 0;
        bool oEntregaInmediata = true;
        Producto p = null;

        SqlConnection oConexion = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexionLibreria"].ConnectionString);

        string oConsulta = "Exec BuscarProducto " + id;
        SqlCommand oComando = new SqlCommand(oConsulta, oConexion);
        SqlDataReader oReader;
        try
        {
            oConexion.Open();
            oReader = oComando.ExecuteReader();

            if (oReader.Read())
            {
                oIdProducto = (int)oReader["IdProducto"];
                oFotoChica = (string)oReader["FotoChica"];
                oFotoGrande = (string)oReader["FotoGrande"];
                oNombre = (string)oReader["Nombre"];
                oPrecio = (double)oReader["Precio"];
                oEntregaInmediata = (bool)oReader["EntregaInmediata"];


                p = new Producto(oIdProducto, oFotoChica, oFotoGrande, oNombre, oPrecio, oEntregaInmediata);
            }
            return p;
        }
        catch (Exception ex)
        {
            throw new ApplicationException("Problemas con la base de datos: " + ex.Message);
        }
        finally
        {
            oConexion.Close();
        }
    }

    public static int Agregar(Producto prod)
    {
        int oResultado = 0;

        SqlConnection oConexion = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexionLibreria"].ConnectionString);

        string oConsulta = "AgregarProducto";
        SqlCommand oComando = new SqlCommand(oConsulta, oConexion);
        oComando.CommandType = CommandType.StoredProcedure;

        oComando.Parameters.AddWithValue("@FotoChica", prod.FotoChica);
        oComando.Parameters.AddWithValue("@FotoGrande", prod.FotoGrande);
        oComando.Parameters.AddWithValue("@Precio", prod.Precio);
        oComando.Parameters.AddWithValue("@Nombre", prod.Nombre);

        SqlParameter oValorRetorno=new SqlParameter("@VR", SqlDbType.Int);
        oValorRetorno.Direction= ParameterDirection.ReturnValue;
        oComando.Parameters.Add(oValorRetorno);

        try
        {
            //Abro la conexión
            oConexion.Open();
            //Ejecuto
            oComando.ExecuteNonQuery();
            //opero
            oResultado = (int)oValorRetorno.Value;
            return oResultado;
        }
        catch (Exception ex)
        {
            throw new ApplicationException("Problemas con la base de datos: " + ex.Message);
        }
        finally
        {
            oConexion.Close();
        }
    }
}


