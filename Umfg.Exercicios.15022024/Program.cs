namespace Umfg.Exercicios._15022024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal cotacaoRealDolar = 0.193259m;

            Console.WriteLine("Entre com a quantidade em reais: ");
            string valor = Console.ReadLine();

            if(decimal.TryParse(valor, out  decimal valorConvertido))
            {
                Console.WriteLine("Valor convertido: " +  valorConvertido * cotacaoRealDolar + " Dolares");
                return;
            }
            Console.WriteLine("O valor deve ser um numero");
        }
    }
}
