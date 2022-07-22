using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animais_poliformismo.src
{
    public class Tigre : Animais
    {
        public Tigre(string nome, int quant, Categoria tipo, MachoFemea sexo) : base(nome, quant, tipo, sexo)
        {
        }
        public override void Comer()
        {
            Console.WriteLine("\n Um(a) Tigre está comendo.");
        }

        public override void Dormir()
        {
            Console.WriteLine("\n Um(a) Tigre está dormindo. ");
        }

        public virtual void Rugir()
        {
            Console.WriteLine("\n Um(a) Tigre está rugindo. ");
        }
    }
}
