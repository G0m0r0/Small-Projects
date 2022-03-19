namespace Restaurant_menu.Products
{
    using System;
    public class Soup : Product
    {
        public Soup(string name, decimal price, double quantity)
           : base(name, price, quantity)
        {
        }

        public override double CalculateCalories()
        {
            throw new NotImplementedException();
        }
    }
}
