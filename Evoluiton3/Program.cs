
using System;

namespace Evoluiton3
{
    class Program
    {
        static void Main(string[] args)
        {
            string valor1 = RemoverCaracteresDuplicados("abracadabra, allottee, assessee");
            string valor2 = RemoverCaracteresDuplicados("kelless, keenness, Alfalggo");
            
            Console.WriteLine(valor1);
            Console.WriteLine(valor2);
            
        }

        static string RemoverCaracteresDuplicados(string texto)
        {
            // Armazena as letras 
            string tabela = "";
            // armazena o resultado
            string resultado = "";
            // Percorre cada caractere do texto
            foreach (char valor in texto)
            {
                // Verifica se o caractere esta na tabela
                if (tabela.IndexOf(valor) == -1)
                {
                    // anexa as letras na tabela e no resultado
                    tabela += valor;
                    resultado += valor;
                }
            }
            return resultado;
        }
    }
}
    

