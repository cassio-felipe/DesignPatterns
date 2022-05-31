using System;
using PatternBuilder.Pattern;
using PatternBuilder.Pattern.Default.ConcreteBuilder;
using PatternBuilder.Pattern.Default.DIrector;
using PatternBuilder.Pattern.SimpleFluent;

namespace PatternBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Builder ===");
            var emailBuilder = new EmailBuilder();
            var email = emailBuilder.To("someemail@gmail.com")
                .From("teste@email.com")
                .Subject("Assunto do Email")
                .Body("Teste de envio de email")
                .Build();
            Console.WriteLine($"{email.From} \n {email.To} \n {email.Subject} \n {email.Body} ");
            Console.ReadLine();
            
            
            Console.WriteLine("=== Default ===");

            var pizzaria = new Pizzaria(new PizzaCalabresa());
            pizzaria.MontaPizza();
            
            var pizza1 = pizzaria.GetPizza();
            pizza1.PizzaConteudo();

            pizzaria = new Pizzaria(new PizzaMussarela());
            pizzaria.MontaPizza();

            var pizza2 = pizzaria.GetPizza();
            pizza2.PizzaConteudo();
        }
    }
}