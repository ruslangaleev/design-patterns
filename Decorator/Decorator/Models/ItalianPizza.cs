namespace Decorator.Models
{
    /// <summary>
    /// Итальянская пицца.
    /// </summary>
    public class ItalianPizza : AbstractPizza
    {
        /// <summary>
        /// Конструктор.
        /// </summary>
        public ItalianPizza() : base("Итальянская пицца")
        {
        }

        /// <summary>
        /// Вернет цену.
        /// </summary>
        public override int GetCost()
        {
            return 10;
        }
    }
}
