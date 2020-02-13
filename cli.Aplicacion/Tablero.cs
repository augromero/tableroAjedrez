using System.Collections.Generic;
using System.Linq;

namespace cli.Aplicacion
{
    public class Tablero
    {
        public Tablero()
        {
            Casillas = new List<Casilla>();
            
            for (int casilla = 1; casilla <= 64; casilla++)
            {
                Casillas.Add(new Casilla(casilla));
            }
        }
        public List<Casilla> Casillas { get; private set; }

        public Color ObtenerColor(Columna columna, int fila)
        {
            return Casillas
                .Where(casilla => 
                    casilla.Columna == columna
                    && casilla.Fila == fila)
                .Select(casilla => casilla.Color)
                .First();
        }
    }

}
