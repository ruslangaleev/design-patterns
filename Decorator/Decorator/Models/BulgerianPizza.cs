namespace Decorator.Models
{
    /// <summary>
    /// Болгарская пицца.
    /// </summary>
    public class BulgerianPizza : AbstractPizza
    {
        /// <summary>
        /// Конструктор.
        /// </summary>
        public BulgerianPizza() : base("Болгарская пицца")
        {

        }

        /// <summary>
        /// Вернет цену.
        /// </summary>
        /// <returns></returns>
        public override int GetCost()
        {
            return 8;
        }
    }
}
