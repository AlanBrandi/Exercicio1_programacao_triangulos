using System;
using System.Globalization;

namespace Exercicio1_programacao
{
    class Program
    { 

        static void Main(string[] args)
        {
            //Declarando variáveis.
            triangulo x, y;

            //Declarando novos triângulos nomeados x e y.
            x = new triangulo();
            y = new triangulo();

            //Pegando os dados que o usuário fornecer e realocando no triangulo X em A, B e C.
            Console.WriteLine("Coloque as medidas do triângulo X:");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // Fórmula matemática + declaração de variável área.
            double p = (x.A + x.B + x.C) / 2;
            double areaX = Math.Sqrt(p * (p - x.A)* (p - x.B) * (p - x.C));

            //montrando o resultado da área do triangulo X + FormatProvider + InvariantCulture
            Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));

            //Pegando os dados que o usuário fornecer e realocando no triangulo Y em A, B e C.
            Console.WriteLine("Coloque as medidas do triângulo Y:");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // Fórmula matemática + declaração de variável área.
            double b = (y.A + y.B + y.C) / 2;
            double areaY = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));

            //montrando o resultado da área do triangulo X + FormatProvider + InvariantCulture
            Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            //Teste para analisar qual área é maior, se é a do triangulo X ou Y.
            if (areaX > areaY)
            {
                Console.WriteLine("O maior triangulo é o X!");
            }
            else
            {
                Console.WriteLine("O maior triangulo é o Y!");
            }
        }
    }
}
