using System;
using System.Collections.Generic;
using System.Text;

namespace MultifabrikenAB
{
    class CarDepartment
    {
        public string Brands;
        public string Colors;
        public string Interiors;
        public string Engines;

        public CarDepartment(string brand, string color, string interior, string engine)
        {
            Brands = brand;
            Colors = color;
            Interiors = interior;
            Engines = engine;
        }

        public static string Brand()
        {
            int menu;
            string brand = "";

            Console.WriteLine("Which brand do you choose for your car?");
            Console.WriteLine("1 Volvo");
            Console.WriteLine("2 BMW");
            Console.WriteLine("3 Mercedes");
            Console.WriteLine("4 Toyota");
            Console.WriteLine("0 Return to main menu");
            menu = UserInput.SubMenu();
            switch (menu)
            {
                case 1:
                    brand = "Volvo";
                    break;
                case 2:
                    brand = "BMW";
                    break;
                case 3:
                    brand = "Mercedes";
                    break;
                case 4:
                    brand = "Toyota";
                    break;
                case 0:
                    Factory factory = new Factory();
                    factory.Run();
                    break;
                default:
                    Console.WriteLine("Faulty input");
                    break;
            }
            return brand;
        }

        public static string Color()
        {
            int menu;
            string color = "";

            Console.WriteLine("Which color do you choose for your car?");
            Console.WriteLine("1 White");
            Console.WriteLine("2 Black");
            Console.WriteLine("3 Red");
            Console.WriteLine("4 Grey");
            Console.WriteLine("0 Return");
            menu = UserInput.SubMenu();
            switch (menu)
            {
                case 1:
                    color = "White";
                    break;
                case 2:
                    color = "Black";
                    break;
                case 3:
                    color = "Red";
                    break;
                case 4:
                    color = "Grey";
                    break;
                case 0:
                    Brand();
                    break;
                default:
                    Console.WriteLine("Faulty input");
                    break;
            }
            return color;
        }

        public static string Interior()
        {
            int menu;
            string interior = "";

            Console.WriteLine("What interior do you choose for your car?");
            Console.WriteLine("1 Leather");
            Console.WriteLine("2 Fabric");
            Console.WriteLine("3 Plastic");
            Console.WriteLine("4 Wood");
            Console.WriteLine("0 Return");
            menu = UserInput.SubMenu();
            switch (menu)
            {
                case 1:
                    interior = "Leather";
                    break;
                case 2:
                    interior = "Fabrik";
                    break;
                case 3:
                    interior = "Plastic";
                    break;
                case 4:
                    interior = "Wood";
                    break;
                case 0:
                    Color();
                    break;
                default:
                    Console.WriteLine("Faulty input");
                    break;
            }
            return interior;
        }

        public static string Engine()
        {
            int menu;
            string engine = "";

            Console.WriteLine("What engine do you choose for your car?");
            Console.WriteLine("1 Sport");
            Console.WriteLine("2 All around");
            Console.WriteLine("3 Green");
            Console.WriteLine("4 Racer");
            Console.WriteLine("0 Return");
            menu = UserInput.SubMenu();
            switch (menu)
            {
                case 1:
                    engine = "Sport";
                    break;
                case 2:
                    engine = "All around";
                    break;
                case 3:
                    engine = "Green";
                    break;
                case 4:
                    engine = "Racer";
                    break;
                case 0:
                    Interior();
                    break;
                default:
                    Console.WriteLine("Faulty input");
                    break;
            }
            return engine;
        }
    }
}
