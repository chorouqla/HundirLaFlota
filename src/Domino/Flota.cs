using System;

    public static class Flota //porque static
    {
        public static List<Barco> CrearFlota()
        {
            return new List<Barco>
            {

            new Barco("Portaaviones", 5, "🚢"),
            new Barco("Acorazado", 4, "🚤"),
            new Barco("Portaaviones", 3, "⛴️"),
            new Barco("Portaaviones", 3, "🛸"),
            new Barco("Portaaviones", 2, "🚣")

            };

        }
    }
