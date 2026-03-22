using System;
public class Tablero
{
    // constante
    private const int Tamano=10; //porque private

    //propiedades
    private Casilla[,]casillas;
    private List<Barco>barcos;

    //constructor
    public Tablero()
    {
        casillas = new Casilla[Tamano,Tamano];//que significa esta linea
        barcos = new List<Barco>();

        for(int i=0;i<Tamano;i++)
        {
            for(int j=0;j<Tamano;j++)
            {
                casillas[i,j]= new Casilla(i,j);
            }
        }
    }


    //metodos
    public Casilla ObtenerCasilla(int fila,int columna)
    {
        return casillas[fila,columna];
    }

    public bool PuedeColocar(Barco barco,int fila, int columna,bool esHorizontal)//que hace este metodo
    {
        return true;
    }

    public  ResultadoDisparo Disparar(int fila,int columna)
    {
        //por ahora 
        return ResultadoDisparo.Agua;
    }

    public bool TodosHundidos //porque bool
    {
        
    }

    public int BarcosRestantes
    {
        
    }

    }