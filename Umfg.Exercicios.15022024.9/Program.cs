using System.Runtime.InteropServices;

namespace Umfg.Exercicios._15022024._9
{
    internal class Program
    {
        struct Livro
        {
            public string Titulo;
            public string Autor;
            public decimal Valor;

            public override string ToString()
            {
                return $"Titulo: {Titulo}, Autor: {Autor}, Valor: {Valor:C}";
            }
        }
        static void Main(string[] args)
        {
            Livro livro = new Livro();

            Console.WriteLine("Insira o titlo do livro: ");
            livro.Titulo = Console.ReadLine();

            Console.WriteLine("Insira o autor do livro: ");
            livro.Autor = Console.ReadLine();

            Console.WriteLine("Insira o valor do livro");
            if (!decimal.TryParse(Console.ReadLine(), out decimal valor))
                return;

            livro.Valor = valor;

            Console.WriteLine(livro);


        }
    }
}
