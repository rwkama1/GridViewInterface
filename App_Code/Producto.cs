using System;
using System.Collections.Generic;
using System.Text;


public class Producto:IBorrar,IComparable
{
    private int _idProducto;
    public int IdProducto
    {
        get { return _idProducto; }
        set { _idProducto = value; }
    }

    private string _fotoChica;
    public string FotoChica
    {
        get { return _fotoChica; }
        set { _fotoChica = value; }
    }
    private string _fotoGrande;
    public string FotoGrande
    {
        get { return _fotoGrande; }
        set { _fotoChica = value; }
    }

    private string _nombre;
    public string Nombre
    {
        get { return _nombre; }
        set { _nombre = value; }
    }
    private double _precio;
    public double Precio
    {
        get { return _precio; }
        set { _precio = value; }
    }

    private bool _entregaInmediata;

    public bool EntregaInmediata
    {
        get { return _entregaInmediata; }
        set { _entregaInmediata = value; }
    }


    public Producto(int idProducto, string fotoChica, string fotoGrande, string nombre, double precio, bool entregaInmediata)
    {
        _idProducto = idProducto;
        _fotoChica = fotoChica;
        _fotoGrande = fotoGrande;
        _nombre = nombre;
        _precio = precio;
        _entregaInmediata = entregaInmediata;
    }

    #region Miembros de IComparable

    public int CompareTo(object obj)
    {

        return this._nombre.CompareTo(((Producto) obj)._nombre);

        
        
    }

    #endregion

    #region Miembros de IBorrar

    public bool MiMetodo(int pNumero)
    {
        return pNumero > 100;       
    }

    #endregion
}

