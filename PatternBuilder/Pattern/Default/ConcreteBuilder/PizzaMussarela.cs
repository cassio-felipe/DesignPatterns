using System;
using System.Collections.Generic;
using PatternBuilder.Pattern.Default.Builder;
using PatternBuilder.Pattern.Default.Product;

namespace PatternBuilder.Pattern.Default.ConcreteBuilder
{
    public class PizzaMussarela : PizzaBuilder
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
                "Mussarela",
                "Molho Tomate",
                "Orégano"
            };
        }
    }
}