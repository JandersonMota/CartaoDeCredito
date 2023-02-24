/* Neste desafio, você implementará regras de negócios que restringem o acesso a usuários com base nas respectivas permissões
 * e nível. Você exibirá uma mensagem diferente para cada usuário, dependendo das respectivas permissões e nível.
 * 
 * Etapa 1: Adicionar código como um ponto de partida
 *  - Para testar a lógica de sua expressão booliana, use o código a seguir de dados de exemplo.
 *  
 *      string permission = "Admin";
 *      int level = 55;
 *      
 *      OU
 *      
 *      string permission = "Manager";
 *      int level = 20;
 *      
 * Etapa 2: Implementar regras de negócios
 *  - Regras de negócios:
 *      1. Se o usuário for um administrador com um nível maior que 55, exiba a mensagem: Welcome, Super Admin user.
 *      2. Se o usuário for um administrador com um nível menor ou igual a 55, exiba a mensagem: Welcome, Admin user.
 *      3. Se o usuário for um gerente com um nível maior ou igual a 20, exiba a mensagem: Contact an Admin for access.
 *      4. Se o usuário for um gerente com um nível menor que 20, exiba a mensagem: You do not have sufficient privileges.
 *      5. Se o usuário não for um administrador nem um gerente, exiba a mensagem: You do not have sufficient privileges.
 * 
 * Etapa 3: Verifique se você obteve a saída de acordo com os dados de exemplo
 *  - Ao executar o código, incluindo os dados de exemplo da Etapa 1, você deverá ver a seguinte saída:
 *      Welcome, Admin user.
 *      
 *      OU
 *      
 *      Contact an Admin for access.
 *      
 * IMPORTANTE:
 * Para determinar se o valor da variável permission contém um dos valores de permissão que você verificará nas "regras de negócio",
 * use o método auxiliar Contains() de uma cadeia de caracteres. Por exemplo, permission.Contains("Admin") retornaria true.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPermissõesComplicadas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string permission = "Admin";
            int level = 55;

            //Manager
            if(level < 20 && permission.Contains("Manager"))
            {
                Console.WriteLine("You do not have sufficient privileges.");
            }
            else if (level >= 20 && permission.Contains("Manager"))
            {
                Console.WriteLine("Contact an Admin for access.");
            }
            //Admin
            else if (level <= 55 && permission.Contains("Admin"))
            {
                Console.WriteLine("Welcome, Admin user.");
            }
            else if (level > 55 && permission.Contains("Admin"))
            {
                Console.WriteLine("Welcome, Super Admin user.");
            }
            else
            { 
                Console.WriteLine("You do not have sufficient privileges."); 
            }

            Console.ReadKey();
        }
    }
}
