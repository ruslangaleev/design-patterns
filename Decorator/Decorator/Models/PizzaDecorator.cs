namespace Decorator.Models
{
    /// <summary>
    /// Декоратор.
    /// </summary>
    public abstract class PizzaDecorator : AbstractPizza
    {
        protected AbstractPizza _pizza;

        public PizzaDecorator(string name, AbstractPizza pizza) : base(name)
        {
            _pizza = pizza;
        }
    }
}
