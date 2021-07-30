using System;
using System.Collections.Generic;
using System.Text;

namespace MultifabrikenAB
{
    class Factory
    {
        public static InventoryDepartment inventorylist = new InventoryDepartment();
        public  void Run()
        {
            int menu = 0;
            do
            {
                Console.WriteLine("Welcome to the MultifabrikenAB");
                Console.WriteLine("1 Place an order");
                Console.WriteLine("2 Print your recit");
                Console.WriteLine("0 Finish your order");
                menu = UserInput.MainMenu();
                switch (menu)
                {
                    case 1:
                        
                        int menu2;
                        do
                        {
                            Console.WriteLine("What would you like to order");
                            Console.WriteLine("1 Car");
                            Console.WriteLine("2 Candy");
                            Console.WriteLine("3 Pipe");
                            Console.WriteLine("0 Return to main menu");
                            menu2 = UserInput.MainMenu();
                            switch (menu2)
                            {
                                case 1:
                                    CarDepartment newCar = new CarDepartment(CarDepartment.Brand(), CarDepartment.Color(), CarDepartment.Interior(), CarDepartment.Engine());
                                    inventorylist.CarList.Add(newCar);
                                    break;
                                case 2:
                                    CandyDepartment newCandy = new CandyDepartment(CandyDepartment.Brand(), CandyDepartment.Flavor(), CandyDepartment.Weight(), CandyDepartment.Size());
                                    inventorylist.CandyList.Add(newCandy);
                                    break;
                                case 3:
                                    PipeDepartment newPipe = new PipeDepartment(PipeDepartment.Brand(), PipeDepartment.Length(), PipeDepartment.Radius(), PipeDepartment.Material());
                                    inventorylist.PipeList.Add(newPipe);
                                    break;
                                case 0:
                                    break;
                                default:
                                    Console.WriteLine("Faulty input");
                                    break;
                            }
                        }
                        while (menu2 != 0);
                        break;
                    case 2:
                        PrintRecit();
                        break;
                    case 0:
                        Console.WriteLine("Finelized order sent");
                        break;
                    default:
                        Console.WriteLine("Faulty input");
                        break;
                }
            }
            while (menu != 0);
        }

        public static void PrintRecit()
        {
            Console.WriteLine("Your order is:");
            Console.WriteLine("-----------------------------------------------------------------");
            int i = 1;
            int j = 1;
            int k = 1;
            foreach (var element in inventorylist.CarList)
            {
                Console.WriteLine("Car " + i);
                i++;
                Console.WriteLine("Brand: " + element.Brands + " Color: " + element.Colors + " Interior: " + element.Interiors + " Engine:" + element.Engines);
                Console.WriteLine("-----------------------------------------------------------------");
            }
            foreach (var element in inventorylist.CandyList)
            {
                Console.WriteLine("Candy " + j);
                j++;
                Console.WriteLine("Brand: " + element.Brands + " Flavor: " + element.Flavors + " Weight: " + element.Weights + " Size: " + element.Sizes);
                Console.WriteLine("-----------------------------------------------------------------");
            }
            foreach (var element in inventorylist.PipeList)
            {
                Console.WriteLine("Pipe " + k);
                k++;
                Console.WriteLine("Brand: " + element.Brands + " Length: " + element.Lengths + " Radius: " + element.Radiuses + " Material:" + element.Materials);
                Console.WriteLine("-----------------------------------------------------------------");
            }

        }

        static void Main(string[] args)
        {
            var myfactory = new Factory();
            myfactory.Run();
            Console.Write("Thank you for chosing MultifabrikenAB and we wish you a good day");
            Console.ReadKey(true);
        }
    }
}
