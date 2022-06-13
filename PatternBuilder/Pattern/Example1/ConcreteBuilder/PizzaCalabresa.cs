using System;
using System.Collections.Generic;
using PatternBuilder.Pattern.Example1.Builder;
using PatternBuilder.Pattern.Example1.Product;

namespace PatternBuilder.Pattern.Example1.ConcreteBuilder
{
    public class PizzaCalabresa : PizzaBuilder
    {
        public override void PreparaMassa()
        {
            Console.WriteLine("== Pizza de Calabresa ==");
            pizza.TipoMassa = TipoMassa.Grossa;
            pizza.TipoBorda = TipoBorda.Normal;
            pizza.Tamanho = Tamanho.Grande;
        }

        public override void IncluiIgredientes()
        {
            pizza.Igredientes = new List<string>
            {
                "Calabresa em fatias",
                "Molho Tomate"
            };
        }
    }
}