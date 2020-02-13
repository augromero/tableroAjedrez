using System;

namespace cli.Aplicacion
{
    class Program
    {
        static void Main(string[] args)
        {
            string recibido;
            Tablero tablero = new Tablero();
            System.Console.WriteLine("digite una coordenada");
            recibido = System.Console.ReadLine();
            Coordenada coordenada = new Coordenada(recibido);
            Color color = tablero.ObtenerColor(coordenada.Columna, coordenada.Fila);
            Console.WriteLine(color.ToString());
        }

    }

}
