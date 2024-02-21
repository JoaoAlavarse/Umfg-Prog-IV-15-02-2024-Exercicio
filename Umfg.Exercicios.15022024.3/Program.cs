namespace Umfg.Exercicios._15022024._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a distancia percorrida em quilometros");
            string distanciaPercorrida = Console.ReadLine();
            Console.WriteLine("Informe o seu gasto de combustivel em litros");
            string gastoCombustivel = Console.ReadLine();

            if (float.TryParse(distanciaPercorrida, out float distanciaPercorridaF) 
                && float.TryParse(gastoCombustivel, out float gastoCombustivelF))
            {
                Console.WriteLine("Voce teve um gasto de: " + distanciaPercorridaF / gastoCombustivelF + " km/L");
                return;
            }
            Console.WriteLine("Valores informados invalidos");
        }
    }
}
