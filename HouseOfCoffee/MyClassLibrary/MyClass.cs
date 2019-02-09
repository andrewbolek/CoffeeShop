using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibrary
{

    public struct Total

    {

        
        public static double totalCoffeeSales, totalCoffeeCostOfGoods;
        public static double totalFoodSales, totalFoodCosts;
        public double EmployeePay;

        public void CalculateCTotals(int total, double[] CoffeePrice, Sizes sizes, double[] CoffeeCost)
        {
            Total.totalCoffeeSales += CoffeePrice[(int)sizes] * total;
            Total.totalCoffeeCostOfGoods += CoffeeCost[(int)sizes] * total;

        }
        public void CalculateFTotals(int total, double[] FoodPrice, Food food,double[] FoodCost)
        {
            Total.totalFoodSales += FoodPrice[(int)food] * total;
            Total.totalFoodCosts += FoodCost[(int)food] * total;
        }
        public double CalculatePay(int hour, double[] HourPay, Pay pay, double[] Overtime, double[] OTDiff)
        {
            if (hour <= 40)
            {
                EmployeePay = HourPay[(int)pay] * hour;
                return EmployeePay;
            }

            else
            {
                EmployeePay = (Overtime[(int)pay] * hour) - (40 * OTDiff[(int)pay]);
                return EmployeePay;

                //(50 * 18.75) - (40 * 6.25)
                // hour * Overtime - 40 * OTDiff
            }
       
        }





    }

    public class Coffee
    {



        public double[] CoffeePrice = { 1.00, 3.00, 5.00 };
        public double[] FoodPrice = { 5.50, 7.50 };
        public double[] CoffeeCost = { .10, .15, .20 };
        public double[] FoodCost = { .95, 1.20 };
        public double[] HourPay = { 12.50 };
        public double[] Overtime = { 18.75 };
        public double[] OTDiff = { 6.25 };
    }

    public enum Menu { Calculate = 1, Pay, Exit }
    public enum Sizes { Small, Medium, Large }
    public enum Food { Egg, Chicken }
    public enum Pay { hourly }
}


    

