using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            var promotionItems = new List<PromotionItem>();
            Console.WriteLine("Please enter total number of Promotion Items");
            var no_Items = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < no_Items; i++)
            {
                Console.WriteLine("Please enter any promotion item of type (A,B,C or D) only :");
                var item = Console.ReadLine();
                PromotionItem proItem = new PromotionItem(item);
                promotionItems.Add(proItem);
            }

            int totalPrice = Get_TotalPrice(promotionItems);
            Console.WriteLine(totalPrice);

            Console.WriteLine("Press Any Key To Stop");
            Console.ReadLine();
        }
        private static int Get_TotalPrice(List<PromotionItem> promotionItems)
        {
            int count_A = 0, count_B = 0, count_C = 0, count_D = 0;
            int price_A = 50, price_B = 30, price_C = 20, price_D = 15;

            foreach (PromotionItem item in promotionItems)
            {
                if (item.Id == "A" || item.Id == "a")
                {
                    count_A = count_A + 1;
                }
                if (item.Id == "B" || item.Id == "b")
                {
                    count_B = count_B + 1;
                }
                if (item.Id == "C" || item.Id == "c")
                {
                    count_C = count_C + 1;
                }
                if (item.Id == "D" || item.Id == "d")
                {
                    count_D = count_D + 1;
                }
            }
            // Active Promotions

            //3 of A's for 130
            int totalPrice_A = (count_A / 3) * 130 + (count_A % 3 * price_A);

            //2 of B's for 45
            int totalPrice_B = (count_B / 2) * 45 + (count_B % 2 * price_B);

            int count_CD = 0;
            if (count_C > 0 && count_D > 0)
            {
                if (count_C > count_D)
                {
                    count_C = count_C - count_D;
                    count_CD = count_D;
                    count_D = 0;
                }
                else if (count_D > count_C)
                {
                    count_D = count_D - count_C;
                    count_CD = count_C;
                    count_C = 0;
                }
                else if (count_C == count_D)
                {
                    count_CD = count_C;
                    count_C = 0;
                    count_D = 0;
                }
            }

            int totalPrice_C = (count_C * price_C);
            int totalPrice_D = (count_D * price_D);

            int totalPrice = totalPrice_A + totalPrice_B + totalPrice_C + totalPrice_D;

            //C & D for 30
            if (count_CD > 0)
            {
                totalPrice = totalPrice + (count_CD * 30);
            }

            return totalPrice;
        }
    }
}

