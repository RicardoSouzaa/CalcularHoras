using System;

namespace CalcularHoras
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Vamos calcular intervalos de tempo???\n\n");

            Console.WriteLine("O que deseja fazer?\n\n 1) SOMAR tempos \n 2) SUBITRAIR tempos");

            int escolha = int.Parse(Console.ReadLine());

            Hora hInicial = new Hora();
            hInicial.PedirHora("INICIAL", "INICIAIS");
            TimeSpan inicio = hInicial.horas;

            Hora hFim = new Hora();
            hFim.PedirHora("FINAL", "FINAIS");
            TimeSpan fim = hFim.horas;
            TimeSpan intervalo = new TimeSpan();

            switch (escolha)
            {
                case 1:
                    intervalo = fim + inicio;
                    break;

                case 2:
                    intervalo = fim - inicio;
                    break;

                default:
                    break;
            }

            Console.WriteLine($"\n\n\nO intervalo de tempo ...: {intervalo.ToString()}");

            Console.ReadLine();
        }
    }
}