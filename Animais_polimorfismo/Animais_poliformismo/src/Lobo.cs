using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animais_poliformismo.src
{
    public class Lobo : Animais
    {
        public Lobo(string nome, int quant, Categoria tipo, MachoFemea sexo) : base(nome, quant, tipo, sexo)
        {
        }

        public override void Comer()
        {
            Console.WriteLine("\n Um(a) Lobo está comendo.");
        }
        public override void Dormir()
        {
            Console.WriteLine("\n Um(a) Lobo está dormindo.");
        }

        public virtual void Uivar()
        {
            Console.WriteLine("\n Um(a) Lobo está uivando. ");
        }
    }
}
