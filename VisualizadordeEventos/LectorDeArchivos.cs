using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualizadordeEventos
{
    public class LectorDeArchivos : RecuperadorDeArchivo, ILectorDeArchivos
    {

        public List<string> ObtenerArchivoLeido()
        {
            return LeerArchivoTXT(RecuperarArchivoTXT());
        }

        
        public List<string> LeerArchivoTXT(StreamReader ArchivoRecuperado)
        {
            String lineas;
            char coma = ',';
            List<string> GuardarEventos = new List<string>();
            

            while ((lineas = ArchivoRecuperado.ReadLine()) != null)
            {
                GuardarEventos = lineas.Split(coma).ToList();   
            }

            return GuardarEventos;
        }
    }
}
