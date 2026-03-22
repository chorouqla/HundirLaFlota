using System;

public class Jugador
{
    //Propiedades
    public string Nombre { get;}
    public Tablero Tablero { get;}
    public int Disparos { get; private set;}//private set?
    public int Aciertos { get; private set; }
    public int Fallos { get; private set; }

    public double Precision => Disparos == 0 ? 0 : (double)Aciertos / Disparos * 100;

    //constructor
    public Jugador(string nombre)
    {
        Nombre = nombre;
        Tablero = new Tablero();
        // Disparos = 0;
        // Aciertos = 0;
        // Fallos = 0;
    }

    //metodos
    public void RegistrarDisparo(ResultadoDisparo resultado)
    {
        Disparos++;
        if (resultado == ResultadoDisparo.Impacto || resultado==ResultadoDisparo.Hundido )
         Aciertos++;
        else if (resultado == ResultadoDisparo.Agua)
        Fallos++;
    }

    // // propiedad calculada
    // public double Precision() //porque double
    // {

    // }
}