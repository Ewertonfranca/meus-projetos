﻿using System;
using EstruturaDoPrograma.exemplos;

namespace EstruturaDoPrograma
{
    class Program
    {
        static void Main()
        {
            var s = new pilha();
            s.Empilha(1);
            s.Empilha(10);
            s.Empilha(100);
            Console.WriteLine(s.Desempilha());
            Console.WriteLine(s.Desempilha());
            Console.WriteLine(s.Desempilha());
            Console.WriteLine(s.Desempilha());
        }
    }
}
