using FormasGeometricas.src;
using System;

namespace FormasGeometricas
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a Forma Geometrica: ");
            string forma = Console.ReadLine();
            Console.WriteLine("Digite a altura: ");
            double h = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a largura: ");
            double b = Convert.ToDouble(Console.ReadLine());

            if (forma == "Triangulo")
            {
                Triangulo ATriang = new Triangulo("Triangulo", h, b);
                Console.WriteLine(ATriang.ToString());
                ATriang.Area();
            }
            else if (forma == "Quadrado")
            {
                Quadrado AQuadrado = new Quadrado("Quadrado", h, b);
                Console.WriteLine(AQuadrado.ToString());
                AQuadrado.Area();
            }
            else if (forma == "Retangulo")
            {
                Retangulo ARetangulo = new Retangulo("Retangulo", h, b);
                Console.WriteLine(ARetangulo.ToString());
                ARetangulo.Area();
            }
            else
            {
                Console.WriteLine("Insira uma forma geometrica valida.");
            }
        }
    }
}
