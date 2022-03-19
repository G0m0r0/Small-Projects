namespace Restaurant_menu.Products
{
    using System;

    public class Salad : Product
    {
        public Salad(string name, decimal price, double quantity)
           : base(name, price, quantity)
        {
        }

        public override double CalculateCalories()
        {
            throw new NotImplementedException();
        }
    }
}
