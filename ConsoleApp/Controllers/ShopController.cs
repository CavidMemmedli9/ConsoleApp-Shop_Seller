using Business.Services;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Utilities;

namespace ConsoleApp.Controllers
{
    public class ShopController
    {


        public ShopService shopService { get; set; }

        public ShopController()
        {
            shopService = new ShopService();
        }
        public void Create()
        {
            Helper.ShowDisplay(ConsoleColor.DarkBlue, "Shop adini daxil et");
            string name = Console.ReadLine();

            Helper.ShowDisplay(ConsoleColor.DarkBlue, "Shop size daxil et");
            WriteAgain: string shopSize = Console.ReadLine();
            int size;
            bool isSize = Int32.TryParse(shopSize, out size);
            if (isSize)
            {

                Shop newShop = new Shop();
                newShop.Name = name;
                newShop.MaxSize = size;
                if (shopService.Create(newShop) != null)
                {
                    Helper.ShowDisplay(ConsoleColor.Cyan, $"{newShop} adli shop yaradildi");
                }
                else
                {
                    Helper.ShowDisplay(ConsoleColor.Red, "something went wrong");
                }
            }
            else
            {
                Helper.ShowDisplay(ConsoleColor.Red, "Duzgun size daxil et");
                goto WriteAgain;
            }

           
        }

        public void GetAll()
        {
            List<Shop> shops = shopService.GetAll();
            foreach (var item in shops)
            {
                Helper.ShowDisplay(ConsoleColor.Magenta, $"Id:{item.Id} name:{item.Name}");
            }
        }

        public void Delete()
        {
            Helper.ShowDisplay(ConsoleColor.Yellow, "silmek istediyim shop id daxil et");
            int id = int.Parse(Console.ReadLine());

            if (shopService.Delete(id) != null)
            {
                Helper.ShowDisplay(ConsoleColor.Yellow, "silindi");
            }
            else
            {
                Helper.ShowDisplay(ConsoleColor.Red, "something went wrong");
            }
        }

        public void Update()
        {
            Helper.ShowDisplay(ConsoleColor.Yellow, "deyismek istediyim shop id daxil et");
            int id = int.Parse(Console.ReadLine());

            Helper.ShowDisplay(ConsoleColor.DarkBlue, "Shop adini daxil et");
            string name = Console.ReadLine();

            Helper.ShowDisplay(ConsoleColor.DarkBlue, "Shop size daxil et");
            int size = int.Parse(Console.ReadLine());

            Shop shop = new Shop
            {
                Name = name,
                MaxSize=size,
           
            };
            if (shopService.Update(id, shop) != null)
            {
                Helper.ShowDisplay(ConsoleColor.Yellow, "Shop update olundu");
            }
            else
            {
                Helper.ShowDisplay(ConsoleColor.Red, "something went wrong");
            }
        }
    }
}
