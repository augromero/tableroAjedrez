using System.Collections.Generic;

namespace cli.Aplicacion
{
    public class Coordenada
    {
        public Columna Columna{get; set;}
        public int Fila { get; set; }
        public Coordenada (string recibido)
        {
            Columna = ConversorColumna[recibido[0]];
            int fila;
            int.TryParse(recibido[1].ToString(), out fila);
            Fila = fila;
        }

        public Dictionary<char, Columna> ConversorColumna => 
            new Dictionary<char, Columna>()
                {
                    {'A', Columna.A},
                    {'B', Columna.B},
                    {'C', Columna.C},
                    {'D', Columna.D},
                    {'E', Columna.E},
                    {'F', Columna.F},
                    {'G', Columna.G},
                    {'H', Columna.H},
                };
    }

}
