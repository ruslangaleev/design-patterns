namespace Decorator.Models
{
    public abstract class AbstractPizza
    {
        /// <summary>
        /// Наименование пиццы.
        /// </summary>
        public string Name { get; protected set; }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="name">Наименование пиццы.</param>
        public AbstractPizza(string name)
        {
            Name = name;
        }
        
        /// <summary>
        /// Вернет цену.
        /// </summary>
        public abstract int GetCost();
    }
}
