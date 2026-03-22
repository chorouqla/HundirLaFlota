using System;

    public class Casilla
    {

        //propiedades
        public int Fila { get; }
        public int Columna { get; }
        public Barco? Barco { get; set; }
        public bool Disparada { get; set; }

        //constructor
        public Casilla(int fila, int columna)
        {
            this.Fila = fila;
            this.Columna = columna;
            Barco = null;
            Disparada = false;
    }

    // Propiedades calculadas
    public bool EstaVacia => Barco == null;
    public bool EsImpacto => Disparada && Barco != null;
    public bool EsAgua => Disparada && Barco == null;
}
