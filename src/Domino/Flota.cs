using System;

public static class Flota //porque static
{
    public static List<Barco> CrearFlota()
    {
        List<Barco> barcos = new List<Barco>(); //explicame cada elemento

        barcos.Add(new Barco("Portaaviones", 5, "🚢"));
        barcos.Add(new Barco("Acorazado", 4, "🚤"));
        barcos.Add(new Barco("Portaaviones", 3, "⛴️"));
        barcos.Add(new Barco("Portaaviones", 3, "🛸"));
        barcos.Add(new Barco("Portaaviones", 2, "🚣"));

        return barcos;

    }
}