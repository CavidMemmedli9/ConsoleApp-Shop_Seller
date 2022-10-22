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
                "8-GetAllSellers"+
                "9-GetAllSellerWithGroupName"+
                "10-GetAllSellerWithSameName");

            while (true)
            {
                string selectMenu = Console.ReadLine();
                int menu;
                bool isChange = Int32.TryParse(selectMenu, out menu);
                if (isChange && menu >= 1 && menu <= 10)
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

                        case (int)Helper.Methods.GetAllSellerWithGroupName:
                            sellerController.GetAllSellerWithGroupName();
                            break;

                        case (int)Helper.Methods.GetAllSellerWithSameName:
                            sellerController.GetAllSsellerWithSameName();
                            break;

                        default:
                            break;

                    }
                }
                else if (menu == 0 && !isChange)
                {
                    Helper.ShowDisplay(ConsoleColor.White, "bye bye");
                    break;
                }
                else
                {
                    Helper.ShowDisplay(ConsoleColor.Red, "Duzgun daxil et");
                }
            }

        }
    }
}

