using System;

public class Tablero
{   //propiedades
    private Casilla[,] grid ;

    //constructor
    public Tablero()
    {

        grid = new Casilla[10, 10];
        for (int fila = 0; fila < 10; fila++)
        {
            for (int col = 0; col < 10; col++)
            {
                grid[fila, col] = new Casilla(fila, col);
            }
        }
    }


    //metodos
    public Casilla ObtenerCasilla(int fila, int columna)
    {
        return grid[fila, columna];
    }

    public bool PuedeColocar(Barco barco, int fila, int columna, bool Horizontal)//que hace este metodo
    {
        for (int i = 0; i < barco.Tamaño; i++)
        {
            int f = fila;
            int c = columna;

            if (Horizontal) c += i;
            else f += i;

            // fuera del tablero
            if (f >= 10 || c >= 10)
                return false;

            // ya hay barco
            if (!grid[f, c].EstaVacia)
                return false;
        }
        return true;
    }
    public void ColocarBarco(Barco barco, int fila, int columna, bool horizontal)
    {
        for (int i = 0; i < barco.Tamaño; i++)
        {
            int f = fila;
            int c = columna;

            if (horizontal) c += i;
            else f += i;

            grid[f, c].Barco = barco;
            barco.Casillas.Add(grid[f, c]);
        }
    }

    public ResultadoDisparo Disparar(int fila, int columna)
    {
        var casilla = grid[fila, columna];

        if (casilla.Disparada)
            return ResultadoDisparo.YaDisparo;

        casilla.Disparada = true;

        if (casilla.Barco == null)
            return ResultadoDisparo.Agua;

        casilla.Barco.RecibirImpacto();

        if (casilla.Barco.EstaHundido)
            return ResultadoDisparo.Hundido;

        return ResultadoDisparo.Impacto;
    }

    public bool TodosHundidos
    {
        get
        {
            foreach (var casilla in grid)
            {
                if (casilla.Barco != null && !casilla.Barco.EstaHundido)
                    return false;
            }
            return true;
        }
    }

    public int BarcosRestantes
    {
        get
        {
            HashSet<Barco> barcos = new();

            foreach (var casilla in grid)
            {
                if (casilla.Barco != null && !casilla.Barco.EstaHundido)
                    barcos.Add(casilla.Barco);
            }

            return barcos.Count;
        }
    }

}