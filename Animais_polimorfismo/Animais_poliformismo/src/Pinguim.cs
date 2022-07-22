using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animais_poliformismo.src
{
    public class Pinguim : Animais
    {
        public Pinguim(string nome, int quant, Categoria tipo, MachoFemea sexo) : base(nome, quant, tipo, sexo)
        {
        }

        public override void Comer()
        {
            Console.WriteLine("\n Um(a) Pinguim está comendo.");
        }
        public override void Dormir()
        {
            Console.WriteLine("\n Um(a) Pinguim está dormindo.");
        }

        public virtual void Nadar()
        {
            Console.WriteLine("\n Um(a) Pinguim está nadando. ");
        }
    }
}
