namespace Restaurant_menu.Products
{
    public class MainDish : Product
    {
        public MainDish(string name, decimal price, double quantity)
           : base(name, price, quantity)
        {
        }

        public override double CalculateCalories()
        {
            return Quantity;
        }
    }
}
