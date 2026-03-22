using System;
public class Casilla
{

    //propiedades
    public int Fila { get; }
    public int Columna { get; }
    public Barco Barco { get; set; }
    public bool Disparada { get; set; }

    //constructor
    public Casilla(int Fila, int Columna)
    {
        this.Fila = Fila;
        this.Columna = Columna;
        this.Barco = null;
        this.Disparada = false;
    }

    //propiedades calculadas
    public bool EstaVacia()
    {
        return Barco == null;
    }

    public bool EsImpacto()
    {
        return Disparada && Barco != null;

    }

    public bool EsAgua()
    {
        return Disparada&& Barco == null;
    }
}