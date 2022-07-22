using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animais_poliformismo.src
{
    public class Animais
    {
        string Nome { get; set; }
        int Quant { get; set; }
        Categoria Tipo { get; set; }
        MachoFemea Sexo { get; set; }

        public Animais(string nome, int quant, Categoria tipo, MachoFemea sexo)
        {
            Nome = nome;
            Quant = quant;
            Tipo = tipo;
            Sexo = sexo;
        }

        public override string ToString()
        {
            return
                $"\n Animal: {Nome}" +
                $"\n Classe: {Tipo}" +
                $"\n Quant: {Quant}" +
                $"\n Sexo: {Sexo}";
        }

        public virtual void Comer()
        {
            Console.WriteLine($"\n Um(a) {Nome} está comendo");
        }

        public virtual void Dormir() 
        {
            Console.WriteLine($"\n Um(a) {Nome} está dormindo");
        }

    }
    public enum Categoria
    {
        CARNIVOROS,
        HERBIVAROS,
        ONIVARIOS
    }

    public enum MachoFemea
    {
        MACHO,
        FEMEA
    }

}
