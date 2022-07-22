using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormasGeometricas.src
{
    public class Formas
    {
        public string Forma { get; set; }
        public double Altura { get; set; }
        public double Largura { get; set; }

        public Formas(string forma, double altura, double largura)
        {
            Forma = forma;
            Altura = altura;
            Largura = largura;
        }

        public override string ToString()
        {
            return
                $"\n Forma: {Forma}" +
                $"\n Altura: {Altura}" +
                $"\n Largura: {Largura}";
        }

        public virtual void Area()
        {
            Console.WriteLine($"\n A area do {Forma} é de: {Altura * Largura} ");
        }

    }
    

}
