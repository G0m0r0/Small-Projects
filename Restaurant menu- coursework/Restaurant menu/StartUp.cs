namespace Restaurant_menu
{
    using Restaurant_menu.Repository;
    using System;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            string command;
            Menu menu = new Menu();


            while ((command = Console.ReadLine()) != "Exit")
            {
                try
                {
                    if (command == "Sales")
                    {
                        Console.WriteLine(menu.ToString()); 
                    }
                    else
                    {
                        var token = command.Split(", ").ToArray()[0];
                        int num = 0;

                        bool isNumeric = int.TryParse(token, out num);
                        if (isNumeric)
                        {
                            menu.OrderProduct(command);
                        }
                        else
                        {
                            menu.AddProductToMenu(command);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Console.WriteLine(menu.ToString());
        }
    }
}
