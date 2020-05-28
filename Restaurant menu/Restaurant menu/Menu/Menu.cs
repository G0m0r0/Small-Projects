namespace Restaurant_menu.Repository
{
    using Restaurant_menu.Products;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Menu
    {
        readonly List<Product> availableProducts;
        readonly Dictionary<int, List<Product>> tables;
        readonly Dictionary<string, int> productsByCategory;
        decimal totalMoney = 0;

        public Menu()
        {
            availableProducts = new List<Product>();
            tables = new Dictionary<int, List<Product>>(30);
            productsByCategory = new Dictionary<string, int>()
            {
                { "Salad",0 },
                { "Soup",0},
                { "MainDish",0 },
                { "Drink",0 },
                { "Dessert",0 }
            };
        }
        public string OrderProduct(string order)
        {
            var tokens = order.Split(", ").ToArray();

            int tableNum =int.Parse( tokens[0]);
            for (int i = 1; i < tokens.Length; i++)
            {
                var product= availableProducts.SingleOrDefault(x => x.Name == tokens[i]);

                if (product.Equals(null))
                {
                    throw new Exception("Product does not exist in the menu!");
                }

                if (!tables.ContainsKey(tableNum))
                {
                    tables[tableNum] = new List<Product>();
                }

                tables[tableNum].Add(product);
                productsByCategory[product.GetType().Name]++;

                totalMoney += product.Price;
            }

            return "Successful order";
        }

        public string AddProductToMenu(string products)
        {
            var tokens = products.Split(", ").ToArray();

            string category = tokens[0].ToLower();
            string name = tokens[1];
            double quantity = double.Parse(tokens[2]);
            decimal price = decimal.Parse(tokens[3]);

            Product product;

            switch (category)
            {
                case "salad":
                    product = new Salad(name, price, quantity);
                    break;
                case "soup":
                    product = new Soup(name, price, quantity);
                    break;
                case "main dish":
                    product = new MainDish(name, price, quantity);
                    break;
                case "dessert":
                    product = new Dessert(name, price, quantity);
                    break;
                case "drink":
                    product = new Drink(name, price, quantity);
                    break;
                default:
                    throw new Exception("Invalid product name");
            }

            availableProducts.Add(product);

            return "Successfully added product to the menu!";
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Occupied tables during the day: {tables.Count}");
            int count = tables.Sum(x => x.Value.Count);
            sb.AppendLine($"All sales: {count} - {totalMoney}");
            sb.AppendLine("By category:");
            foreach (var item in productsByCategory)
            {
                decimal totalMoneyForProduct=0;
                foreach (var tableItem in tables)
                {
                    foreach (var product in tableItem.Value)
                    {
                        if (product.GetType().Name.ToLower() == item.Key.ToLower())
                        {
                            totalMoneyForProduct += product.Price;
                        }
                    }
                }
                

                sb.AppendLine($"-   {item.Key}: {item.Value} - {totalMoneyForProduct}");
                totalMoneyForProduct = 0;
            }

            return sb.ToString().Trim();
        }
    }
}
