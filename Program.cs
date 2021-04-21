using System;
using System.Linq;
using System.Collections.Generic;

namespace ejercicio3
{
    public sealed class ListGenericaExpresionLambda
    {
        public static void Main()
        {
            List<string> paises = new List<string> { "Colombia", "Perú", "Canada",
                "Francia", "China", "Groenlandia", "Inglaterra", "Haiti", "Holanda"
            };

            // Espreción lambda pais => pais.Lenght <= 6 en método Where:
            IEnumerable<string> consulta = paises.Where(pais => pais.Length <= 6);

            // Resultado:
            Console.WriteLine("\nNombres de países con número de caracteres <= 6:");
            foreach (string pais in consulta)
            {
                Console.WriteLine("\t{0}", pais);
            }

            List<int> numeros = new List<int> { 0, 1, 2, 3, 5, 6, 7, 8, 9, 10 };

            // Genera `IEnumerable` con números impares:
            IEnumerable<int> impares = numeros.Where(numero => numero % 2 != 0);

            // Genera `IEnumerable` con números pares:
            IEnumerable<int> pares = numeros.Where(numero => numero % 2 == 0);

            // Resultado
            Console.WriteLine("\nNúmeros impares en `numeros`:");
            foreach (int numero in impares)
            {
                Console.WriteLine("\t{0}", numero.ToString());
            }

            // Resultado
            Console.WriteLine("\nNúmeros pares en `numeros`:");
            foreach (int numero in pares)
            {
                Console.WriteLine("\t{0}", numero.ToString());
            }
        }
    }
}