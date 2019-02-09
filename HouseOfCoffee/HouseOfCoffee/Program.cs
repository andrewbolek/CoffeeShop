using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClassLibrary;

namespace HouseOfCoffee
{
    class Program
    {
       
        static void Main(string[] args)
        {
           
            Switch();
        }
        static void Switch()
        {


            Console.Clear();
            int result;
            string Time =DateTime.Now.ToString("h:mm:ss tt");
            
            Console.WriteLine($"                                                 Coffee Shop           {Time}    \n\n\n\n");
            Console.WriteLine("Press [1] for Total Sales\n\nPress [2] for employees Pay\n\nPress [3] to exit\n");
            int.TryParse(Console.ReadLine(), out result);
            switch (result)
            {
                case (int)Menu.Calculate:
                    Sales();
                    break;
                case (int)Menu.Pay:

                    Pay();
                    break;
                case (int)Menu.Exit:
                    Exit();
                    break;
                default:


                    Switch();
                    break;
                
            }
            Console.ReadLine();
        }
        static void Sales()
        {


            string Time = DateTime.Now.ToString("h:mm:ss tt");
            Console.Clear();
            Console.WriteLine($"                                                 Sales                 {Time}\n\n\n\n");
            
         
            Coffee coffee = new Coffee();
            Total ttl = new Total();
            try
            {
                Console.WriteLine("Please enter the amount of Small coffees sold.");
                
                int Small = Int32.Parse(Console.ReadLine());
                ttl.CalculateCTotals(Small,coffee.CoffeePrice, Sizes.Small, coffee.CoffeeCost );
               

                 Console.WriteLine("Please enter the amount of Medium coffees sold.");

                int Medium = Int32.Parse(Console.ReadLine());
                ttl.CalculateCTotals(Medium, coffee.CoffeePrice, Sizes.Medium, coffee.CoffeeCost);
          
                Console.WriteLine("Please enter the amount of Large coffees sold.");

                int Large = Int32.Parse(Console.ReadLine());
                ttl.CalculateCTotals(Large, coffee.CoffeePrice, Sizes.Large, coffee.CoffeeCost);

                Console.WriteLine("Please enter the amount of egg sandwiches sold that day");
                int Egg = Int32.Parse(Console.ReadLine());
                ttl.CalculateFTotals(Egg, coffee.FoodPrice, Food.Egg, coffee.FoodCost);


                Console.WriteLine("Please enter the amount of chicken biscuits sold that day");
                int Chicken = Int32.Parse(Console.ReadLine());
                ttl.CalculateFTotals(Chicken, coffee.FoodPrice, Food.Chicken, coffee.FoodCost);

                Console.WriteLine($"Your total Profit is...\n ");
                Task.Delay(1000).Wait();
                Console.WriteLine($"                              ${ Total.totalCoffeeSales + Total.totalFoodSales - Total.totalFoodCosts - Total.totalCoffeeCostOfGoods}");
                Console.ReadLine();
                Switch();
            }
            catch
            {
                Console.WriteLine("error");
                Sales();
            }
            









        }

        static void Pay()
        {
            Coffee coffee = new Coffee();
            Total ttl = new Total();

            string Time = DateTime.Now.ToString("h:mm:ss tt");
            Console.Clear();
            Console.WriteLine($"                                                 Pay                   {Time}\n\n\n\n");
            
            Console.WriteLine("Please enter your first employees hours\n");

            int Emp1 = Int32.Parse(Console.ReadLine());
            double Emp1Pay = ttl.CalculatePay(Emp1, coffee.HourPay, MyClassLibrary.Pay.hourly, coffee.Overtime, coffee.OTDiff);
            
            
            Console.WriteLine("\nPlease enter your second employees hours\n");

            int Emp2 = Int32.Parse(Console.ReadLine());
            double Emp2Pay = ttl.CalculatePay(Emp2, coffee.HourPay, MyClassLibrary.Pay.hourly, coffee.Overtime, coffee.OTDiff);
            
            Console.WriteLine("\nPlease enter your third employees hours\n");

            int Emp3 = Int32.Parse(Console.ReadLine());
            double Emp3Pay = ttl.CalculatePay(Emp3, coffee.HourPay, MyClassLibrary.Pay.hourly, coffee.Overtime, coffee.OTDiff);
            
            Console.WriteLine("\nPlease enter your fourth employees hours\n");

            int Emp4 = Int32.Parse(Console.ReadLine());
            double Emp4Pay = ttl.CalculatePay(Emp4, coffee.HourPay, MyClassLibrary.Pay.hourly, coffee.Overtime, coffee.OTDiff);
            
            Console.WriteLine("\nPlease enter your fifth employees hours\n");

            int Emp5 = Int32.Parse(Console.ReadLine());
            double Emp5Pay = ttl.CalculatePay(Emp5, coffee.HourPay, MyClassLibrary.Pay.hourly, coffee.Overtime, coffee.OTDiff);
           

            Console.Clear();
            Console.WriteLine($"                                                 Pay                   {Time}\n\n\n\n");
            Console.WriteLine($"Your employees weekly pay comes out to...");
            Task.Delay(1000).Wait();
            Console.WriteLine(

                $"\n Employee 1 = ${Emp1Pay} " +

                $"\n Employee 2 = ${Emp2Pay}" +

                $"\n Employee 3 = ${Emp3Pay} " +

                $"\n Employee 4 = ${Emp4Pay}" +

                $"\n Employee 5 = ${Emp5Pay}");

            double TotalPay = Emp1Pay + Emp2Pay + Emp3Pay + Emp4Pay + Emp5Pay;
            Console.WriteLine($"\n Your total employee pay comes out to ${TotalPay}");
            Console.ReadLine();
            Switch();



        }







        static void Exit()
        {
            string Time = DateTime.Now.ToString("h:mm:ss tt");
            Console.Clear();
            Console.WriteLine($"                                                                       {Time}\n\n\n\n\n\n\n\n\n                                                 Goodbye!              ");
            Task.Delay(1000).Wait();
            System.Environment.Exit(1);
        }
    }

}
