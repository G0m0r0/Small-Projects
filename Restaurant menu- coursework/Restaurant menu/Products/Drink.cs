namespace Restaurant_menu.Products
{
    public class Drink : Product
    {
        public Drink(string name, decimal price, double quantity)
          : base(name, price, quantity)
        {
        }



        public override double CalculateCalories()
        {
            return Quantity * 1.5;
        }
    }
}
