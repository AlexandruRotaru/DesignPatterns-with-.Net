using Common.Interfaces;
using FactoryMethodPattern.ConcreteProduct;
using FactoryMethodPattern.Creator;
using FactoryMethodPattern.Product;
using System.Collections.Generic;

namespace FactoryMethodPattern.ConcreteCreator
{
    public class ChicagoStylePizzaStore : PizzaStore
    {
        private readonly Dictionary<string, Pizza> pizaTypes;

        public ChicagoStylePizzaStore(IView view)
        {
            pizaTypes = new Dictionary<string, Pizza>()
            {
                { "cheese", new ChicagoStyleCheesePizza(view) },
                { "pepperoni", new  ChicagoStylePepperoniPizza(view) },
                { "veggie", new  ChicagoStyleVeggyPizza(view)}
            };
        }

        protected override Pizza CreatePizza(string type)
        {
            if (pizaTypes.TryGetValue(type, out Pizza selectedPizza))
            {
                return selectedPizza;
            }

            throw new System.Exception($"Wrong pizza type {type} in {nameof(ChicagoStylePizzaStore)}");
        }
    }
}
