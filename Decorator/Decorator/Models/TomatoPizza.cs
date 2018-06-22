namespace Decorator.Models
{
    public class TomatoPizza : PizzaDecorator
    {
        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="p"></param>
        public TomatoPizza(AbstractPizza p) : base(p.Name + ", с томатами", p)
        {

        }

        /// <summary>
        /// Вернет цену.
        /// </summary>
        public override int GetCost()
        {
            return _pizza.GetCost() + 3;
        }
    }
}
