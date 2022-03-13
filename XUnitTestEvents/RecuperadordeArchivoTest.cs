using Xunit;
using VisualizadordeEventos;

namespace XUnitTestEvents
{
#nullable enable
    public class RecuperadordeArchivoTest
    {
        private RecuperadorDeArchivo RecuperarArchivo = new RecuperadorDeArchivo();

        [Theory(DisplayName = "Dado un archivo, cuando se ejecuta RecuperarArchivoTXT, entonces solo lee el tipo .txt")]
        [InlineData("Archivo.jpg")]
        [InlineData("Archivo.docx")]
        [InlineData("Archivo.txt")]
        public void DadoUnArchivoCuandoSeEjecutaRecuperarArchivoTXTEntoncesSoloLeeElTipotxt(string NombreDeArchivoRecuperado) 
        {
            //Assert 
            Assert.True(ComprobarSiElArchivoEsDeTipotxt(NombreDeArchivoRecuperado));
        }

        private bool ComprobarSiElArchivoEsDeTipotxt(string nombreDeArchivoRecuperado)
        {
            //Arrange y Act
            bool ArchivoRecuperado = RecuperarArchivo.ArchivoEsTipoTXT(nombreDeArchivoRecuperado);

            //Condition
            if (ArchivoRecuperado.Equals(true))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
