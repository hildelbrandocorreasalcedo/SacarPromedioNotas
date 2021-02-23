using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SacarPromedioNotas
{
    class Program
    {
        static void Main(string[] args)
        {

            double nota1;
            double nota2;
            double nota3;

            double promedio;
            Console.Write("***********Sacar promedio de 3 notas********* ");
            Console.Write("Digitar notas entre (0.0 a 5.0)\n");
            Console.Write("Digite la nota 1: ");
            nota1 = double.Parse(Console.ReadLine());
            Console.Write("Digite la nota 2: ");
            nota2 = double.Parse(Console.ReadLine());
            Console.Write("Digite la nota 3: ");
            nota3 = double.Parse(Console.ReadLine());
            promedio = (nota1 + nota2 + nota3) / 3;

            if ((promedio >= 3.0 && promedio <= 5.0))
            {
                Console.WriteLine($"Su promedio fue de {promedio}, ha GANADO!!!");
            }
            else if (promedio < 3.0 && promedio >=0.0)
            {
                Console.WriteLine($"Su promedio fue de {promedio}, ha PERDIDO");
            }
            else
            {
                Console.WriteLine($"debe digitar valores entre (0.0 a 5.0)");
            }

            Console.ReadKey();
        }
    }
}
