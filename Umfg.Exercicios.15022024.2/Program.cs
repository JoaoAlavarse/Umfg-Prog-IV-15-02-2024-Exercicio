namespace Umfg.Exercicios._15022024._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal cotacaoDolarReal = 5.22m;

            Console.WriteLine("Entre com a quantidade em dolares: ");
            string valor = Console.ReadLine();

            if (decimal.TryParse(valor, out decimal valorConvertido))
            {
                Console.WriteLine("Valor convertido: " + valorConvertido * cotacaoDolarReal + " Reais");
                return;
            }
            Console.WriteLine("O valor deve ser um numero");
        }
    }
}
