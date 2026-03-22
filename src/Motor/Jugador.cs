using System;

public class Jugador
{
    //Propiedades
    public string Nombre { get; set; }
    public Tablero Tablero { get; set; }
    public int Disparos { get; private set}//private set?
    public int Aciertos { get; private set; }
    public int Fallos { get; private set; }

    //constructor
    public Jugador(string Nombre)
    {
        Nombre = Nombre;
        Tablero = new Tablero();
        Disparos = 0;
        Aciertos = 0;
        Fallos = 0;
    }

    //metodos
    public void RegistrarDisparo(ResultadoDisparo resultado)
    {
        Disparos++;
        //...
    }

    // propiedad calculada
    public double Precision() //porque double
    {

    }
}