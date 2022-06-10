using System;

namespace CalcularHoras
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Vamos calcular o tempo decorrido\n\n");

            Hora hInicial = new Hora();
            hInicial.PedirHora("INICIAL", "INICIAIS");
            TimeSpan inicio = hInicial.horas;

            Hora hFim = new Hora();
            hFim.PedirHora("FINAL", "FINAIS");
            TimeSpan fim = hFim.horas;

            TimeSpan intervalo = fim - inicio;

            Console.WriteLine($"\n\n\nO intervalo de tempo ...: {intervalo.ToString()}");

            Console.ReadLine();
        }
    }
}