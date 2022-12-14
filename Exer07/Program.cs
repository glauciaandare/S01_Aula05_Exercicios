/*
 * 7) Num programa que lê um valor inteiro, faça a sua validação através do tratamento de uma exceção. Caso não
 *  seja inteiro continuar pedindo a introdução do valor inteiro. 
 */

namespace Exer07 {
    internal class Program {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Informe um número Inteiro: ");
                int numero = Convert.ToInt32(Console.ReadLine());
                while (numero != 0)
                {
                    Console.WriteLine("Informe um número Inteiro: ");
                }           


            }
            catch (FormatException erro)
            {
                Console.WriteLine("O número dever ser inteiro");
                Console.WriteLine(erro.Message);
            }
            catch (DivideByZeroException erro)
            {
                Console.WriteLine("Divisão por zero");
                Console.WriteLine(erro.Message);
            }
            finally
            {
                Console.WriteLine("Fim");
            }
        }
    }
}