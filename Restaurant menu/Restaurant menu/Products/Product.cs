namespace Restaurant_menu.Products
{
    using System;
    using System.Linq;

    public abstract class Product
    {
        private string name;
        private decimal price;
        private double quantity;

        public Product(string name, decimal price, double quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }
      
        public double Quantity
        {
            get => quantity;
            set
            {
                if (quantity < 0 || quantity > 1000)
                {
                    throw new Exception("Invalid quantity!");
                }
                quantity=value;
            }
        }
        public string Name
        {
            get => name;
            private set
            {
                if(!(value.All(Char.IsLetter)||value.Contains(' ')))
                {
                    throw new Exception("Name does not contains only letters!");
                }

                name = value;
            }
        }

        public decimal Price
        {
            get => price;
            private set
            {
                if (price < 0 || price > 100)
                {
                    throw new Exception("Invalid price!");
                }
                price = value;
            }
        }

        public abstract double CalculateCalories();
    }
}
