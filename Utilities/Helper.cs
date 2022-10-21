using System;
using System.Collections.Generic;
using System.Text;

namespace Utilities
{
   public  class Helper
    {
        public static void ShowDisplay(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public enum ShopMethods
        {
            CreateShop=1,
            UpdateShop,
            DeleteShop,
            GetShopById,
            GetShopByName,
            GetAll
        }
    }
}
