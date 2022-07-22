using Animais_poliformismo.src;
using System;

namespace Animais_poliformismo
{
    public class Zoo
    {
        static void Main(string[] args)
        {
            Buffalo buffalo = new Buffalo("Buffalo", 1, Categoria.HERBIVAROS, MachoFemea.MACHO);
            Lobo lobo = new Lobo("Lobo", 1, Categoria.CARNIVOROS, MachoFemea.FEMEA);
            Tigre tigre = new Tigre("Tigre", 1, Categoria.CARNIVOROS, MachoFemea.MACHO);
            Pinguim pinguim = new Pinguim("Pinguim", 5, Categoria.ONIVARIOS, MachoFemea.FEMEA);
            Tigre tigresa = new Tigre("Tigresa", 2, Categoria.CARNIVOROS, MachoFemea.FEMEA);

            Console.WriteLine(buffalo.ToString());
            buffalo.Mugir();
            
            Console.WriteLine(lobo.ToString()); 
            lobo.Uivar();

            Console.WriteLine(tigre.ToString());
            tigre.Rugir();

            Console.WriteLine(tigresa.ToString());
            tigresa.Comer();
            tigresa.Dormir();

            Console.WriteLine(pinguim.ToString());
            pinguim.Comer();
            pinguim.Comer();
            pinguim.Dormir();
            pinguim.Nadar();
            pinguim.Dormir();

        }
    }
}
