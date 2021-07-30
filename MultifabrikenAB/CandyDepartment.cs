using System;
using System.Collections.Generic;
using System.Text;

namespace MultifabrikenAB
{
    class CandyDepartment
    {
        public string Brands;
        public string Flavors;
        public string Weights;
        public string Sizes;

        public CandyDepartment(string brand, string flavor, string weight, string size)
        {
            Brands = brand;
            Flavors = flavor;
            Weights = weight;
            Sizes = size;
        }

        public static string Brand()
        {
            int menu;
            string brand = "";

            Console.WriteLine("Which brand do you choose for your candy?");
            Console.WriteLine("1 Skittles");
            Console.WriteLine("2 Werther´s Original");
            Console.WriteLine("3 Malaco");
            Console.WriteLine("4 Haribo");
            Console.WriteLine("0 Return to main menu");
            menu = UserInput.SubMenu();
            switch (menu)
            {
                case 1:
                    brand = "Skittles";
                    break;
                case 2:
                    brand = "Werther´s Original";
                    break;
                case 3:
                    brand = "Malaco";
                    break;
                case 4:
                    brand = "Haribo";
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

        public static string Flavor()
        {
            int menu;
            string flavor = "";

            Console.WriteLine("Which flavor do you choose?");
            Console.WriteLine("1 Sour");
            Console.WriteLine("2 Sweet");
            Console.WriteLine("3 Salt");
            Console.WriteLine("4 Orignal");
            Console.WriteLine("0 Return");
            menu = UserInput.SubMenu();
            switch (menu)
            {
                case 1:
                    flavor = "Sour";
                    break;
                case 2:
                    flavor = "Sweet";
                    break;
                case 3:
                    flavor = "Salt";
                    break;
                case 4:
                    flavor = "Orignal";
                    break;
                case 0:
                    Brand();
                    break;
                default:
                    Console.WriteLine("Faulty input");
                    break;
            }
            return flavor;
        }

        public static string Weight()
        {
            int menu;
            string weight = "";

            Console.WriteLine("How much candy would you like?");
            Console.WriteLine("1 1 hg");
            Console.WriteLine("2 5 hg");
            Console.WriteLine("3 1 kg");
            Console.WriteLine("4 5 kg");
            Console.WriteLine("0 Return");
            menu = UserInput.SubMenu();
            switch (menu)
            {
                case 1:
                    weight = "1 hg";
                    break;
                case 2:
                    weight = "5 hg";
                    break;
                case 3:
                    weight = "1 kg";
                    break;
                case 4:
                    weight = "5 kg";
                    break;
                case 0:
                    Flavor();
                    break;
                default:
                    Console.WriteLine("Faulty input");
                    break;
            }
            return weight;
        }

        public static string Size()
        {
            int menu;
            string size = "";

            Console.WriteLine("What candy size would you like?");
            Console.WriteLine("1 Smal");
            Console.WriteLine("2 Medium");
            Console.WriteLine("3 Large");
            Console.WriteLine("4 Extra large");
            Console.WriteLine("0 Return");
            menu = UserInput.SubMenu();
            switch (menu)
            {
                case 1:
                    size = "Smal";
                    break;
                case 2:
                    size = "Medium";
                    break;
                case 3:
                    size = "Large";
                    break;
                case 4:
                    size = "Extra large";
                    break;
                case 0:
                    Weight();
                    break;
                default:
                    Console.WriteLine("Faulty input");
                    break;
            }
            return size;
        }
    }
}
