using Business.Services;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Utilities;

namespace ConsoleApp.Controllers
{
   public class SellerController
    {
        public SellerService sellerService { get; set; }

        public SellerController()
        {
            sellerService = new SellerService();
        }
        public void Create()
        {
            Helper.ShowDisplay(ConsoleColor.DarkBlue, "Shop adini daxil et");
            string shopName = Console.ReadLine();

            Helper.ShowDisplay(ConsoleColor.DarkBlue, "satici adini daxil et");
            string name = Console.ReadLine();

            Helper.ShowDisplay(ConsoleColor.DarkBlue, "satici soyadini daxil et");
            string surName = Console.ReadLine();


            Seller seller = new Seller
            {
                Name=name,
                Surname=surName,
            };
            if (sellerService.Create(seller, shopName) != null)
            {
                Helper.ShowDisplay(ConsoleColor.Green, $"{seller.Name}  satici yaradildi");
            }
            else
            {
                Helper.ShowDisplay(ConsoleColor.Red, "something went wrong");
            }
        }

        public void GetAll()
        {
            Helper.ShowDisplay(ConsoleColor.DarkBlue, "saticilarin siyahisi");
            List<Seller> sellers = sellerService.GetAll();
            foreach (var item in sellers)
            {
                Helper.ShowDisplay(ConsoleColor.DarkBlue, $"{item.Id}  {item.Name}  {item.Surname}  ");
            }
        }



    }
}
