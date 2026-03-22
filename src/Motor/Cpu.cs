
public class Cpu : Jugador
{
    private List<(int, int)> objetivos;
    private Random rnd = new Random();
    public Cpu() : base("CPU")
    {
        objetivos = new List<(int, int)>();

        for (int i = 0; i < 10; i++)
            for (int j = 0; j < 10; j++)
                objetivos.Add((i, j));

        Mezclar();
    }

    private void Mezclar()
    {

        for (int i = objetivos.Count - 1; i > 0; i--)
        {
            int j = rnd.Next(i + 1);
            (objetivos[i], objetivos[j]) = (objetivos[j], objetivos[i]);
        }
    }

    public (int, int) ElegirObjetivo()
    {
        var objetivo = objetivos[0];
        objetivos.RemoveAt(0);
        return objetivo;
    }
}
