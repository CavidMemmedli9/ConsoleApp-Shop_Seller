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
            SellerController sellerController = new SellerController();

            Helper.ShowDisplay(ConsoleColor.Blue, "1-Create Shop" +
                "2-Update Shop" +
                "3-Delete Shop" +
                "4-GetSshopById" +
                "5-GetShopByName" +
                "6-GetAllShop" +
                "7-CreateSeller"+
                "8-GetAllSellers");

            while (true)
            {
                string selectMenu = Console.ReadLine();
                int menu;
                bool isChange = Int32.TryParse(selectMenu, out menu);
                if (isChange && menu >= 1 && menu <= 8)
                {
                    switch (menu)
                    {
                        case (int)Helper.Methods.CreateShop:

                            shopController.Create();

                            break;

                        case (int)Helper.Methods.DeleteShop:
                            shopController.GetAll();
                            break;

                        case (int)Helper.Methods.UpdateShop:
                            shopController.Update();
                            break;


                        case (int)Helper.Methods.GetShopByName:
                            shopController.GetWithName();
                            break;

                        case (int)Helper.Methods.GetShopById:
                            shopController.GetWwithId();
                            break;

                        case (int)Helper.Methods.GetAllShop:
                            shopController.GetAll();
                            break;


                        case (int)Helper.Methods.CreateSeller:
                            sellerController.Create();
                            break;

                        case (int)Helper.Methods.GetAllSellers:
                            sellerController.GetAll();
                            break;

                        default:
                            break;

                    }
                }
            }

        }
    }
}

