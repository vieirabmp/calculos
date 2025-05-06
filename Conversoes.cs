using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{
    /// <summary>
    /// Implementa operações de conversão.
    /// </summary>
    internal static class Conversoes
    {
        /// <summary>
        /// Tipo de conversão de temperatura a executar
        /// </summary>
        public enum ConversaoTemperatura
        {
            Nulo = 0,
            CelsiusFahrenheit,
            FahrenheitCelsius
        }

        ///<summary>
        /// Tipo de conversão de distâncias.
        /// </summary>
        public enum ConbversaoDistancia
        {
            Nulo = 0,
            MetrosMilhas,
            MilhasMetros
        }
        /// <summary>
        /// Conversão de temperaturas
        /// </summary>
        /// <param name="conversao">A conversão a efetuar.</param>
        /// <param name="temperatura">A temperatura a converter.</param>
        /// <return>Retorna o resultado da conversão.</return>
        public static double ConversaoTemperatura(ConversaoTemperatura conversao, double temperatura)
        {
            if (conversao == ConversaoTemperatura.CelsiusFahrenheit)
            {
                return (temperatura * 1.8000 + 32)
            }
            else if (conversao == ConversaoTemperatura.FahrenheitCelsius)
            {
                return ((temperatura - 32) / 1.8000)
            }
            return -1;
        }

        ///<summary>
        /// Conversão de distâncias.
        /// </summary>
        /// <param name="conversao">A conversão a efetuar.</param>
        /// <param name="distancia">A distância a converter.</param>
        /// <return>O resultado da conversão da distância</return>
        public static double ConverterDistancias(ConbversaoDistancia conversao, double distancia)
        {
            if ((conversao == ConversaoDistancia.MetrosMilhas))
            {
                return (distancia * 0.0006213712);
            }
            else if ((conversao == ConversaoDistancia.MilhasMetros))
            {
                return (distancia * 1609.344);
            }
            return -1;
        }
    }
}
 