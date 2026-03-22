public class Juego
{
    private Jugador jugador ;
    private Cpu cpu;
    private Renderizador render;

    public Juego()
    {
        jugador = new Jugador("Jugador");
        cpu = new Cpu();
        render = new Renderizador();
    }

    public void Iniciar()
    {
        Console.WriteLine("=== HUNDIR LA FLOTA ===");

        // colocar barcos rápido (temporal)
        var flotaJugador = Flota.CrearFlota();
        jugador.Tablero.ColocarBarco(flotaJugador);

        var flotaCpu = Flota.CrearFlota();
        cpu.Tablero.ColocarBarco(flotaCpu);

        while (true)
        {
            render.MostrarTablero(jugador.Tablero);
            render.MostrarTablero(cpu.Tablero); // mostrar ambos

            Console.WriteLine("Turno (fila columna):");
            int f = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            var res = cpu.Tablero.Disparar(f, c);
            jugador.RegistrarDisparo(res);

            Console.WriteLine($"Resultado: {res}");

            if (cpu.Tablero.TodosHundidos)
            {
                Console.WriteLine("==== GANASTE ====");
                break;
            }

            // TURNO CPU
            var (fc, cc) = cpu.ElegirObjetivo();
            var resCpu = jugador.Tablero.Disparar(fc, cc);
            cpu.RegistrarDisparo(resCpu);

            Console.WriteLine($"CPU dispara a {fc},{cc}: {resCpu}");

            if (jugador.Tablero.TodosHundidos)
            {
                Console.WriteLine("💀 PERDISTE");
                break;
            }
    }
}
}