using Microsoft.VisualStudio.TestTools.UnitTesting;
using cli.Aplicacion;
using System.Linq;

namespace cli.Tests
{
    [TestClass]
    public class UnitTest1
    {
              
        [TestMethod]
        public void Debe_Tablero_Tener64Casillas()
        {
            Tablero tablero = new Tablero();

            Assert.AreEqual(64, tablero.Casillas.Count);
        }

        [TestMethod]
        public void Debe_PrimeraCasilla_SerA1Blanco()
        {
            Tablero tablero = new Tablero();

            Casilla casillaA1 = tablero.Casillas.First();

            Assert.AreEqual(Columna.A, casillaA1.Columna);
            Assert.AreEqual(1, casillaA1.Fila);
            Assert.AreEqual(Color.BLANCO, casillaA1.Color);
        }

        [TestMethod]
        public void Debe_SegundaCasilla_SerB1Negro()
        {
            Tablero tablero = new Tablero();

            Casilla casillaA1 = tablero.Casillas[1];

            Assert.AreEqual(Columna.B, casillaA1.Columna);
            Assert.AreEqual(1, casillaA1.Fila);
            Assert.AreEqual(Color.NEGRO, casillaA1.Color);
        }

        [TestMethod]
        public void Debe_TerceraCasilla_SerC1Blanco()
        {
            Tablero tablero = new Tablero();

            Casilla casillaA1 = tablero.Casillas[2];

            Assert.AreEqual(Columna.C, casillaA1.Columna);
            Assert.AreEqual(1, casillaA1.Fila);
            Assert.AreEqual(Color.BLANCO, casillaA1.Color);
        }

        [TestMethod]
        public void Debe_OctavaCasilla_SerH1Negro()
        {
            Tablero tablero = new Tablero();

            Casilla casillaA1 = tablero.Casillas[7];

            Assert.AreEqual(Columna.H, casillaA1.Columna);
            Assert.AreEqual(1, casillaA1.Fila);
            Assert.AreEqual(Color.NEGRO, casillaA1.Color);
        }

        [TestMethod]
        public void Debe_PrimeraCasillaDeSegundaFual_SerA2Negro()
        {
            Tablero tablero = new Tablero();

            Casilla casillaA1 = tablero.Casillas[8];

            Assert.AreEqual(Columna.A, casillaA1.Columna);
            Assert.AreEqual(2, casillaA1.Fila);
            Assert.AreEqual(Color.NEGRO, casillaA1.Color);
        }

        [TestMethod]
        public void Debe_UltimaCasillaDeSegundaFual_SerH2Blanco()
        {
            Tablero tablero = new Tablero();

            Casilla casillaA1 = tablero.Casillas[15];

            Assert.AreEqual(Columna.H, casillaA1.Columna);
            Assert.AreEqual(2, casillaA1.Fila);
            Assert.AreEqual(Color.BLANCO, casillaA1.Color);
        }

        [TestMethod]
        public void Debe_PrimeraCasillaDeTerceraFila_SerA3Blanco()
        {
            Tablero tablero = new Tablero();

            Casilla casillaA1 = tablero.Casillas[16];

            Assert.AreEqual(Columna.A, casillaA1.Columna);
            Assert.AreEqual(3, casillaA1.Fila);
            Assert.AreEqual(Color.BLANCO, casillaA1.Color);
        }

        [TestMethod]
        public void Debe_UltimaCasillaDeTerceraFila_SerH3Negro()
        {
            Tablero tablero = new Tablero();

            Casilla casillaA1 = tablero.Casillas[23];

            Assert.AreEqual(Columna.H, casillaA1.Columna);
            Assert.AreEqual(3, casillaA1.Fila);
            Assert.AreEqual(Color.NEGRO, casillaA1.Color);
        }

        [TestMethod]
        public void Debe_UltimaCasillaDeOctavaFila_SerH3Negro()
        {
            Tablero tablero = new Tablero();

            Casilla casillaA1 = tablero.Casillas[63];

            Assert.AreEqual(Columna.H, casillaA1.Columna);
            Assert.AreEqual(8, casillaA1.Fila);
            Assert.AreEqual(Color.BLANCO, casillaA1.Color);
        }

        [TestMethod]
        public void Debe_CuandoSolicitaPorCoordenada_RetornarColor()
        {
            Tablero tablero = new Tablero();

            Color color = tablero.ObtenerColor(Columna.E, 4);

            Assert.AreEqual(Color.NEGRO, color);
        }
        [TestMethod]
        public void Debe_separar_parametros_de_coordenada()
        {
            string recibido = "A1";
            Coordenada coordenada = new Coordenada(recibido);
            Assert.AreEqual(Columna.A,coordenada.Columna);
            Assert.AreEqual(1,coordenada.Fila);
        }
        
    }
}
