using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_DDMasivi_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] masivs = new int[10, 10];

            Random rand = new Random();
            for (int rinda = 0; rinda < 10; rinda++)
            {
                for (int kolonna = 0; kolonna < 10; kolonna++)
                {
                    masivs[rinda, kolonna] = rand.Next(1, 101); 
                }
            }

            Console.WriteLine("Sākotnējais masīvs:");
            for (int rinda = 0; rinda < 10; rinda++)
            {
                for (int kolonna = 0; kolonna < 10; kolonna++)
                {
                    Console.Write($"{masivs[rinda, kolonna],4}");
                }
                Console.WriteLine();
            }

            // Samaina rindas un kolonnas vietām
            int[,] samainitsMasivs = new int[10, 10];
            for (int rinda = 0; rinda < 10; rinda++)
            {
                for (int kolonna = 0; kolonna < 10; kolonna++)
                {
                    samainitsMasivs[kolonna, rinda] = masivs[rinda, kolonna];
                }
            }

            Console.WriteLine("\nMasīvs pēc rindu un kolonnu samainīšanas:");
            for (int rinda = 0; rinda < 10; rinda++)
            {
                for (int kolonna = 0; kolonna < 10; kolonna++)
                {
                    Console.Write($"{samainitsMasivs[rinda, kolonna],4}");
                }
                Console.WriteLine();
            }
        }
    }
}
