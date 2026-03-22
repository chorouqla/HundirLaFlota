using System;
public class Barco
{
    //propiedades
    public string Nombre { get; }
    public int Tamaño { get; }
    public string Emoji { get; } //porque get
    private int Impactos; // pporque private(ENCAPSULACION)
    public List<Casilla> Casillas { get; } //porque get 

    public Barco(string Nombre, int Tamaño, string Emoji, string Impactos)
    {
        this.Nombre = Nombre;
        this.Tamaño = Tamaño;
        this.Emoji = Emoji;
        this.Impactos = 0;
        Casillas = new List<Casilla>();
    }

    // metodos
    public void RecibirImpacto()
    {
        if (!EstaHundido)
        {
            Impactos++;
        }
    }

    //propiedad calculada
    public bool EstaHundido()
    {
        return Impactos >= Tamaño;
    }


