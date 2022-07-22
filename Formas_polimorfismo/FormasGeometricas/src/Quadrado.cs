﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormasGeometricas.src
{
    internal class Quadrado : Formas
    {
        public Quadrado(string forma, double altura, double largura) : base(forma, altura, largura)
        {
        }
        public override void Area()
        {
            Console.WriteLine($"\n A area do {Forma} é de: {Altura * Largura} ");
        }
    }
}
