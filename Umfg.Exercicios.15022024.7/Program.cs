using System.ComponentModel.DataAnnotations.Schema;

namespace Umfg.Exercicios._15022024._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string vogais = "AEIOUaeiou";
            int contagem = 0;

            Console.WriteLine("Informe seu nome: ");
            string nome = Console.ReadLine();

            foreach (char caractere in nome)
            {
                if (vogais.IndexOf(caractere) < 0)
                {
                    contagem++;
                }
            }
            Console.WriteLine("Quantidade de consoantes: " + contagem);
        }
    }
}
