using PatternBuilder.Pattern.Default.Product;

namespace PatternBuilder.Pattern.Default.Builder
{
    public abstract class PizzaBuilder
    {
        protected Pizza pizza;

        public void CriarPizza()
        {
            pizza = new Pizza();
        }

        public Pizza getPizza()
        {
            return pizza;
        }

        public abstract void PreparaMassa();
        public abstract void IncluiIgredientes();
    }
}