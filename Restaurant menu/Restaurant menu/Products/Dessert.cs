namespace Restaurant_menu.Products
{
    public class Dessert : Product
    {
        public Dessert(string name, decimal price,double quantity) 
            : base(name, price,quantity)
        {
        }

        public override double CalculateCalories()
        {
            return Quantity * 3;
        }
    }
}
