using Common.Interfaces;
using FactoryMethodPattern.ConcreteProduct;
using FactoryMethodPattern.Creator;
using FactoryMethodPattern.Product;
using System.Collections.Generic;

namespace FactoryMethodPattern.ConcreteCreator
{
    public class NYStylePizzaStore : PizzaStore
    {
        private readonly Dictionary<string, Pizza> pizaTypes;

        public NYStylePizzaStore(IView view)
        {
            pizaTypes = new Dictionary<string, Pizza>()
            {
                { "cheese", new NYStyleCheesePizza(view) },
                { "pepperoni", new  NYStylePepperoniPizza(view) },
                { "veggie", new  NYStyleVeggyPizza(view)}
            };
        }

        protected override Pizza CreatePizza(string type)
        {
            if(pizaTypes.TryGetValue(type, out Pizza selectedPizza))
            {
                return selectedPizza;
            }

            throw new System.Exception($"Wrong pizza type {type} in {nameof(NYStylePizzaStore)}");
        }
    }
}
