using System;
using System.Collections.Generic;

namespace ASM2
{   
    class Program
    {

        public static int Order(string drinkName, Dictionary<string, int> price)
        {
            int sum = 0;
            string size;
            Console.WriteLine("How many cups of {0} do you want to drink ? ", drinkName);
            int amount = int.Parse(Console.ReadLine());
            for (int i = 0; i < amount; i++)
            {
                Console.WriteLine("What size do you want? We have 2 type: M - XL");
                size = Console.ReadLine();
                if (price.ContainsKey(size))
                {
                    sum += price[size];
                }
                else
                {
                    break;
                }
            }
            return sum;
        }
        static void Main(string[] args)
        {
            int sum = 0;
            Drink Coffee = new Drink();
            Coffee.Name = "coffee";
            Console.WriteLine("name: {0}", Coffee.Name);
            Drink Tea = new Drink();
            Tea.Name = "tea";
            Console.WriteLine("name: {0}", Tea.Name);
            Drink Milk = new Drink();
            Milk.Name = "milk";
            Console.WriteLine("name: {0}", Milk.Name);
            Console.WriteLine("**************MAIN MENU***********");
            Console.WriteLine("***************DRINKS************");
            Console.WriteLine("1.   COFFEE");
            Console.WriteLine("2.   TEA");
            Console.WriteLine("3.   MILK");
            Console.WriteLine("4.   EXIT");
            Console.WriteLine("Let's choice the number to order:");
            string a = Console.ReadLine();
            while (a != "close")
            {
                Console.WriteLine("Let's choose your number: ");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        sum += Order(Coffee.Name, Coffee.Price);
                        
                        break;
                    case 2:

                        Console.WriteLine(Tea.Name);
                        break;
                    case 3:

                        Console.WriteLine(Milk.Name);
                        break;
                    case 4:
                        a = "close";
                        break;
                    default:
                        Console.WriteLine("Please re-enter !!!");
                        break;
                }
                Console.WriteLine("YOUR BILL");
                Console.WriteLine(sum);
            }
            
        }
    }
}
