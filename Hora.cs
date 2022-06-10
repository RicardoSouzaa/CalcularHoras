using System;
using System.Collections.Generic;
using System.Text;

namespace CalcularHoras
{
    public class Hora
    {
        public int hora { get; set; }
        public int min { get; set; }
        public int seg { get; set; }

        public TimeSpan horas { get; set; }

        public void PedirHora(string h, string m)

        {
            seg = 0;

            Console.Write($"\n\nEntre com a HORA {h}...:");
            hora = int.Parse(Console.ReadLine());

            Console.Write($"\nEntre com os MINUTOS {m}....:");
            min = int.Parse(Console.ReadLine());

            horas = new TimeSpan(hora, min, seg);
        }
    }
}