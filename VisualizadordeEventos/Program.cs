using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualizadordeEventos
{
    public class Program
    {

        static void Main(string[] args)
        {

            //Lee el archivo

            StreamReader ArchivoRecuperado = new StreamReader("../../eventos.txt");

            String lineas;
            List <string> GuardarEventos= new List<string>();
            char coma = ',';

            //
            while ((lineas = ArchivoRecuperado.ReadLine()) != null)
            {
                Console.WriteLine(lineas);

                //String[] ElementosDeLaLineaSinLasComas=lineas.Split(';');
                GuardarEventos= (lineas.Split(coma).ToList());
                Console.WriteLine(GuardarEventos[0]);
                Console.WriteLine(GuardarEventos[1]);

            }

        }
    }
}
