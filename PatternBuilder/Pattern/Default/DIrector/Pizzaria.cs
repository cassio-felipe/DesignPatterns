using PatternBuilder.Pattern.Default.Builder;
using PatternBuilder.Pattern.Default.Product;

namespace PatternBuilder.Pattern.Default.DIrector
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