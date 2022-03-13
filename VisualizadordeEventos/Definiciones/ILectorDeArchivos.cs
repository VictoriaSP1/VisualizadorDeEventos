using System.Collections.Generic;
using System.IO;

namespace VisualizadordeEventos
{
    public interface ILectorDeArchivos
    {
        

        List<string> LeerArchivoTXT(StreamReader ArchivoRecuperado);

        
        
    }
}