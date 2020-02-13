using Microsoft.VisualStudio.TestTools.UnitTesting;
using cli.Aplicacion;
using System.Linq;

namespace cli.Tests
{
    [TestClass]
    public class TableroAjedrezUnitTest
    {
        private Tablero _tablero;
        [TestInitialize]
        public void Inicializar()
        {
            _tablero = new Tablero();
        }

        [TestMethod]
        public void Debe_Tablero_Tener64Casillas()
        {
            Assert.AreEqual(64, _tablero.Casillas.Count);
        }

        [TestMethod]
        public void Debe_PrimeraCasilla_SerA1Blanco()
        {
            Casilla casilla = _tablero.Casillas.First();

            Assert.AreEqual(Columna.A, casilla.Columna);
            Assert.AreEqual(1, casilla.Fila);
            Assert.AreEqual(Color.BLANCO, casilla.Color);
        }

        [TestMethod]
        public void Debe_SegundaCasilla_SerB1Negro()
        {
            Casilla casilla = _tablero.Casillas[1];

            Assert.AreEqual(Columna.B, casilla.Columna);
            Assert.AreEqual(1, casilla.Fila);
            Assert.AreEqual(Color.NEGRO, casilla.Color);
        }

        [TestMethod]
        public void Debe_TerceraCasilla_SerC1Blanco()
        {
            Casilla casilla = _tablero.Casillas[2];

            Assert.AreEqual(Columna.C, casilla.Columna);
            Assert.AreEqual(1, casilla.Fila);
            Assert.AreEqual(Color.BLANCO, casilla.Color);
        }

        [TestMethod]
        public void Debe_OctavaCasilla_SerH1Negro()
        {
            Casilla casilla = _tablero.Casillas[7];

            Assert.AreEqual(Columna.H, casilla.Columna);
            Assert.AreEqual(1, casilla.Fila);
            Assert.AreEqual(Color.NEGRO, casilla.Color);
        }

        [TestMethod]
        public void Debe_PrimeraCasillaDeSegundaFual_SerA2Negro()
        {
            Casilla casilla = _tablero.Casillas[8];

            Assert.AreEqual(Columna.A, casilla.Columna);
            Assert.AreEqual(2, casilla.Fila);
            Assert.AreEqual(Color.NEGRO, casilla.Color);
        }

        [TestMethod]
        public void Debe_UltimaCasillaDeSegundaFual_SerH2Blanco()
        {
            Casilla casilla = _tablero.Casillas[15];

            Assert.AreEqual(Columna.H, casilla.Columna);
            Assert.AreEqual(2, casilla.Fila);
            Assert.AreEqual(Color.BLANCO, casilla.Color);
        }

        [TestMethod]
        public void Debe_PrimeraCasillaDeTerceraFila_SerA3Blanco()
        {
            Casilla casilla = _tablero.Casillas[16];

            Assert.AreEqual(Columna.A, casilla.Columna);
            Assert.AreEqual(3, casilla.Fila);
            Assert.AreEqual(Color.BLANCO, casilla.Color);
        }

        [TestMethod]
        public void Debe_UltimaCasillaDeTerceraFila_SerH3Negro()
        {
            Casilla casilla = _tablero.Casillas[23];

            Assert.AreEqual(Columna.H, casilla.Columna);
            Assert.AreEqual(3, casilla.Fila);
            Assert.AreEqual(Color.NEGRO, casilla.Color);
        }

        [TestMethod]
        public void Debe_UltimaCasillaDeOctavaFila_SerH3Negro()
        {
            Casilla casilla = _tablero.Casillas[63];

            Assert.AreEqual(Columna.H, casilla.Columna);
            Assert.AreEqual(8, casilla.Fila);
            Assert.AreEqual(Color.BLANCO, casilla.Color);
        }

        [TestMethod]
        public void Debe_CuandoSolicitaPorCoordenada_RetornarColor()
        {
            Color color = _tablero.ObtenerColor(Columna.E, 4);

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
