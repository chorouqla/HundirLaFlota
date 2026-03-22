using System;

public class Barco
{
    //propiedades
    public string Nombre { get; }
    public int Tamaño { get; }
    public string Emoji { get; }
    public int Impactos{get;private set;} // pporque private set
    public List<Casilla> Casillas { get; }  

    public Barco(string nombre, int tamaño, string emoji)
    {
        Nombre = nombre;
        Tamaño = tamaño;
        Impactos = 0;
        Emoji = emoji;
        Casillas = new List<Casilla>();
    }

    // metodos
    public void RecibirImpacto()
    {
        
            Impactos++;
        
    }

    public bool EstaHundido => Impactos >= Tamaño;
}


