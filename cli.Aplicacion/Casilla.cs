namespace cli.Aplicacion
{
    public class Casilla
    {
        private const int dimensionTablero = 8;

        public Columna Columna { get; private set; }
        public int Fila { get; private set; }
        public Color Color { get; private set; }

        public Casilla(int posicion)
        {
            CalcularFila(posicion);
            CalcularColumna(posicion);
            SeleccionarColor();
        }
        
        private void CalcularFila(int posicion)
        {
            Fila = ((posicion - 1) / dimensionTablero) + 1;
        }
        private void CalcularColumna(int posicion)
        {
            Columna = (Columna)(posicion % (dimensionTablero));
        }

        private void SeleccionarColor()
        {
            if(esImpar(Fila) == esImpar((int)Columna))
                Color = Color.BLANCO;
            else
                Color = Color.NEGRO;
            
        }
        private bool esImpar(int numero)
        {
            return numero % 2 != 0;
        }
    }

}
