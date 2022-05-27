using System;
using PatternBuilder.Pattern;

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
        }
    }
}