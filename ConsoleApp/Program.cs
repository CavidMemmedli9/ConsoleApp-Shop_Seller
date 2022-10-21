using Business.Services;
using ConsoleApp.Controllers;
using Entities.Models;
using System;
using System.Collections.Generic;
using Utilities;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            

            ShopController shopController = new ShopController();

            Helper.ShowDisplay(ConsoleColor.Blue, "1-Create Shop" +
                "2-Update Shop" +
                "3-Delete Shop" +
                "4-GetSshopById" +
                "5-GetShopByName" +
                "6-GetAll");

            while (true)
            {
            string selectMenu = Console.ReadLine();
                int menu;
                bool isChange = Int32.TryParse(selectMenu, out menu);
                if (isChange && menu >= 1 && menu <= 6)
                {
                    switch (menu)
                    {
                        case (int)Helper.ShopMethods.CreateShop:

                            shopController.Create();

                            break;

                        case (int)Helper.ShopMethods.DeleteShop:
                            shopController.GetAll();
                            break;

                            case(int)Helper.ShopMethods.UpdateShop:
                            shopController.Update();
                            break;


                        case (int)Helper.ShopMethods.GetShopByName:
                            shopController.GetWithName();
                            break;

                        case (int)Helper.ShopMethods.GetShopById:
                            shopController.GetWwithId();
                            break;

                        case 6:

                            shopController.GetAll();
                            break;

                    }
                }
            }

        }
    }
}

