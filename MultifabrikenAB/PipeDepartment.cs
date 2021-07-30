using System;
using System.Collections.Generic;
using System.Text;

namespace MultifabrikenAB
{
    class PipeDepartment
    {
        public string Brands;
        public string Lengths;
        public string Radiuses;
        public string Materials;

        public PipeDepartment(string brand, string length, string radius, string material)
        {
            Brands = brand;
            Lengths = length;
            Radiuses = radius;
            Materials = material;
        }

        public static string Brand()
        {
            int menu;
            string brand = "";

            Console.WriteLine("Which brand do you choose for your pipe?");
            Console.WriteLine("1 Turner Industries");
            Console.WriteLine("2 American SpiralWeld Pipe Co");
            Console.WriteLine("3 Atkore International");
            Console.WriteLine("4 Welspun Tubular");
            Console.WriteLine("0 Return to main menu");
            menu = UserInput.SubMenu();
            switch (menu)
            {
                case 1:
                    brand = "Turner Industries";
                    break;
                case 2:
                    brand = "American SpiralWeld Pipe Co";
                    break;
                case 3:
                    brand = "Atkore International";
                    break;
                case 4:
                    brand = "Welspun Tubular";
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

        public static string Length()
        {
            int menu;
            string length = "";

            Console.WriteLine("What length would you like?");
            Console.WriteLine("1 0,5 m");
            Console.WriteLine("2 1 m");
            Console.WriteLine("3 5 m");
            Console.WriteLine("4 10 m");
            Console.WriteLine("0 Return");
            menu = UserInput.SubMenu();
            switch (menu)
            {
                case 1:
                    length = "0,5 m";
                    break;
                case 2:
                    length = "1 m";
                    break;
                case 3:
                    length = "5 m";
                    break;
                case 4:
                    length = "10 m";
                    break;
                case 0:
                    Brand();
                    break;
                default:
                    Console.WriteLine("Faulty input");
                    break;
            }
            return length;
        }

        public static string Radius()
        {
            int menu;
            string Radius = "";

            Console.WriteLine("What radius would you like?");
            Console.WriteLine("1 25 mm");
            Console.WriteLine("2 50 mm");
            Console.WriteLine("3 100 mm");
            Console.WriteLine("4 150 mm");
            Console.WriteLine("0 Return");
            menu = UserInput.SubMenu();
            switch (menu)
            {
                case 1:
                    Radius = "25 mm";
                    break;
                case 2:
                    Radius = "50 mm";
                    break;
                case 3:
                    Radius = "100 mm";
                    break;
                case 4:
                    Radius = "150 mm";
                    break;
                case 0:
                    Length();
                    break;
                default:
                    Console.WriteLine("Faulty input");
                    break;
            }
            return Radius;
        }

        public static string Material()
        {
            int menu;
            string material = "";

            Console.WriteLine("What material would you like?");
            Console.WriteLine("1 Steel");
            Console.WriteLine("2 Aluminium");
            Console.WriteLine("3 Stainless steel");
            Console.WriteLine("4 Black sheet metal");
            Console.WriteLine("0 Return");
            menu = UserInput.SubMenu();
            switch (menu)
            {
                case 1:
                    material = "Steel";
                    break;
                case 2:
                    material = "Aluminium";
                    break;
                case 3:
                    material = "Stainless steel";
                    break;
                case 4:
                    material = "Black sheet metal";
                    break;
                case 0:
                    Radius();
                    break;
                default:
                    Console.WriteLine("Faulty input");
                    break;
            }
            return material;
        }
    }
}
