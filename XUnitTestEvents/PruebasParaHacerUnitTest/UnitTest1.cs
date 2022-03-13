using Xunit;
using VisualizadordeEventos;
using System;
using VisualizadordeEventos.PruebasParaHacerUnitTest;

namespace XUnitTestEvents
{
    public class UnitTest1
    {
        [Fact (DisplayName ="Dados dos números, cuando se ejecuta el método suma, entonces se imprime numeroavalidar")]
        public void SumaTestPrueba()
        {
            //Arrange 

            var proyecto = new Operaciones();
            int numeroavalidar = 30;
            int a = 10;
            int b = 20;


            //Act
            int numeroavalidado = proyecto.suma(a,b);

            //Assert
            Assert.Equal(numeroavalidar, numeroavalidado);

        }

        [Theory (DisplayName = "Cuando se reste, dará 30")]
        [InlineData(34, 4)]
        [InlineData(40, 10)]
        public void RestaTestPrueba (int a, int b)
        {
            
            //Assert
            Assert.True(Resultado(a, b));
        }

        private bool Resultado(int a, int b)
        {
            //Arrange
            var Proyecto = new Operaciones();
            int c = a+b;

            //Act
            int restaentera = Proyecto.resta(a, b);


            //Condition
            if (c == restaentera)
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