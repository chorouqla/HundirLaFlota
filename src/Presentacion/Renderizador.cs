public class Renderizador
{
    public void MostrarTablero(Tablero tablero)
    {
        for (int fila = 0; fila < 10; fila++)
        {
            for (int col = 0; col < 10; col++)
            {
                var casilla = tablero.ObtenerCasilla(fila, col);


                if (!casilla.Disparada)
                Console.Write(". ");
                else if(casilla.EsAgua)
                Console.Write("~ ");
                else
                    Console.Write("X ");
            }
            Console.WriteLine();
        }
    }
}