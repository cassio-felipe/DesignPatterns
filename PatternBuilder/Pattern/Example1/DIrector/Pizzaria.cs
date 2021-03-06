using PatternBuilder.Pattern.Example1.Builder;
using PatternBuilder.Pattern.Example1.Product;

namespace PatternBuilder.Pattern.Example1.DIrector
{
    public class Pizzaria
    {
        private readonly PizzaBuilder _builder;
        
        public Pizzaria(PizzaBuilder builder)
        {
            _builder = builder;
        }

        public void MontaPizza()
        {
            _builder.CriarPizza();
            _builder.PreparaMassa();
            _builder.IncluiIgredientes();
        }

        public Pizza GetPizza()
        {
            return _builder.getPizza();
        }
    }
}