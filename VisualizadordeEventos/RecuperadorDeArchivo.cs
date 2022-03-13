using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualizadordeEventos
{
    public class RecuperadorDeArchivo: IRecuperadorDeArchivo
    {
        string RutaDelArchivoTXT;
        string RaizDelProyecto;
        string NombreDeArchivo;

        public RecuperadorDeArchivo()
        {
            this.RaizDelProyecto = "../../";
            this.NombreDeArchivo = "eventos.txt";
            this.RutaDelArchivoTXT = this.RaizDelProyecto + this.NombreDeArchivo;
        }

        public StreamReader RecuperarArchivoTXT()
        {
            RutaDelArchivoTXT = ComprobacionesDeArchivoCorrectas();
            StreamReader ArchivoRecuperado = new StreamReader(RutaDelArchivoTXT);

            return ArchivoRecuperado;
        }

        public string ComprobacionesDeArchivoCorrectas()
        {
            string TipoDeArchivoAceptado = ".txt";
            string NombreDeArchivoAceptado = "eventos";
            string RaizDelProyectoAceptada = "../../";


            bool NombreCorrecto = NombreDelArchivoEsCorrecto(NombreDeArchivo).Equals(NombreDeArchivoAceptado);
            bool RutaDelProyectoCorrecta = ArchivoEnCarpetaRaizDelProyecto(RaizDelProyecto).Equals(RaizDelProyectoAceptada);
            bool TipoDeArchivoCorrecto = ArchivoEsTipoTXT(NombreDeArchivo);

            if (NombreCorrecto.Equals(true) && RutaDelProyectoCorrecta.Equals(true) && TipoDeArchivoCorrecto.Equals(true))
            {
                return RutaDelArchivoTXT;
            }
            return null;
        }

        public bool ArchivoEsTipoTXT(string NombreDeArchivo)
        {
            string TipoDeArchivoAceptado = ".txt";
            int TamanioDeRutaArchivoTXT = RutaDelArchivoTXT.Length;
            string ObtenerTipoDeArchivo = RutaDelArchivoTXT.Substring(TamanioDeRutaArchivoTXT - 4, TamanioDeRutaArchivoTXT);


            if (ObtenerTipoDeArchivo.Equals(TipoDeArchivoAceptado))
            {
                return true;
            }
            else
            {
                throw new Exception("Se esperaba un archivo de tipo .txt");
            }
        }

        public bool NombreDelArchivoEsCorrecto(string NombreDeArchivo)
        {
            string NombreDeArchivoAceptado = "eventos";
            int TamanioDeRutaArchivoTXT = RutaDelArchivoTXT.Length - 4;
            string ObtenerNombreDeArchivo = RutaDelArchivoTXT.Substring(TamanioDeRutaArchivoTXT, TamanioDeRutaArchivoTXT);

            if (ObtenerNombreDeArchivo.Equals(NombreDeArchivoAceptado))
            {
                return true;
            }
            else
            {
                throw new Exception("Se esperaba el nombre " + NombreDeArchivoAceptado);
            }

        }

        public bool ArchivoEnCarpetaRaizDelProyecto(string RaizDelProyecto)
        {
            string RaizDelProyectoAceptada = "../../";

            if (RaizDelProyecto.Equals(RaizDelProyectoAceptada))
            {
                return true;
            }
            else
            {
                throw new Exception("Se esperaba la ruta " + RaizDelProyectoAceptada);
            }

        }
    }
}
