/* Nesse desafio, você lançará uma moeda para exibir heads ou tails. Este é um cenário perfeito para o operador condicional.
 * Etapa 1: Escreva o código para exibir o resultado de um lançamento de moeda.
 *  - Use a classe Random para gerar um valor. Com base no valor, use o operador condicional para exibir heads ou tails.
 *  - As chances de que o resultado seja cara ou coroa devem ser de 50% cada.
 *  - Você deve ser capaz de realizar o resultado desejado em três linhas de código ou menos.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioCaraOuCoroa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            int roll = rand.Next(1, 3);

            Console.WriteLine("Resultado: " + ((roll == 1) ? "Heads" : "Tails"));

            Console.ReadKey();
        }
    }
}
