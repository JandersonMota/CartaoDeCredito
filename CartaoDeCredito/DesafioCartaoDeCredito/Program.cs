using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Imagine que você trabalha no departamento antifraude de uma empresa que conecta vendedores online com anunciantes com
 * direito à comissão. Nossos anunciantes informaram sobre um recente pico nos estornos de cartão de crédito. Esses estornos
 * ocorreram alguns meses após o pagamento das comissões, muito depois de os ladrões desaparecerem. Com isso, a equipe
 * detectou um padrão. Pedidos que começam com a letra "B" têm um número de fraudes 25 vezes maior que o normal.
 * 
 * Para a equipe de fraudes investigar ainda mais, será necessario que você escreva um código que identifica o ID do pedido
 * inicializado com a letra "B".
 * 
 * OBSERVAÇÂO:
 * Utilize os dados da ID de pedido falsa que deve ser usada para inicializar a matriz.
 * B123, C234, A345, C15, B177, G3003, C235, B179
 * 
 * DICA:
 * Para esse desafio recomendo o usso dos seguintes comando:
 * Matriz, Loop foreach, Lógica de decisão (if), NOME_DA_VARIAVEL.StartsWith("B")
*/

namespace DesafioCartaoDeCredito
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] pedidoFalsoID = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

            foreach (var item in pedidoFalsoID)
            {
                if (item.StartsWith("B"))
                {
                    Console.WriteLine($"{item}");
                }
            }

            Console.ReadKey();
        }
    }
}
