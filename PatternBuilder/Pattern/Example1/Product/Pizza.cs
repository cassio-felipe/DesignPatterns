using System;
using System.Collections.Generic;

namespace PatternBuilder.Pattern.Example1.Product
{
    public class Pizza
    {
        public TipoMassa TipoMassa { get; set; }
        public TipoBorda TipoBorda { get; set; }
        public Tamanho Tamanho { get; set; }
        public List<string> Igredientes { get; set; }

        public void PizzaConteudo()
        {
            Console.WriteLine($"Pizza com massa: {TipoMassa}");
            Console.WriteLine($"Pizza com borda: {TipoBorda}");
            Console.WriteLine($"Pizza com tamanho: {Tamanho}");
            Console.WriteLine($"Pizza com igredientes");

            foreach (var item in Igredientes)
            {
                Console.WriteLine($" {item}");
            }
        }
    }
}