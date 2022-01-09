using System;
using System.Collections.Generic;
using System.Text;


public class Producto
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

   
}

