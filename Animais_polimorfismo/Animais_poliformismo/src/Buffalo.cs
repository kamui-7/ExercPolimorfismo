using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animais_poliformismo.src
{
    public class Buffalo : Animais
    {
        public Buffalo(string nome, int quant, Categoria tipo, MachoFemea sexo) : base(nome, quant, tipo, sexo)
        {
        }

        public override void Comer()
        {
            Console.WriteLine("\n Um(a) Buffalo está comendo.");
        }
        public override void Dormir()
        {
            Console.WriteLine("\n Um(a) Buffalo está dormindo.");
        }

        public void Mugir()
        {
            Console.WriteLine("\n Um(a) Buffalo está mugindo. ");
        }
    }
}
