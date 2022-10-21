using Business.Interfaces;
using DataAccess.Repositories;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Services
{
    public class ShopService : IShop
    {
        public ShopRepository shopRepository { get; set; }
        public static int Count { get; set; }
        public ShopService()
        {
            shopRepository = new ShopRepository();
        }
        public Shop Create(Shop shop)
        {
            try
            {
                Shop existShop = shopRepository.Get(s => s.Name.ToLower() == shop.Name.ToLower());
                if (existShop != null)
                {
                    return null;
                }
                shop.Id = Count;
                shopRepository.Add(shop);
                Count++;
                return shop;
            }
            catch (Exception)
            {
                return null;
                
            }
        }

        public Shop Delete(int id)
        {
            try
            {
                Shop existShop = shopRepository.Get(g => g.Id == id);
                if (existShop != null)
                {
                    shopRepository.Remove(existShop);
                    return existShop;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {

                return null;
            }
        }

        public Shop Get(int id)
        {
            throw new NotImplementedException();
        }

        public Shop Get(string name)
        {
            throw new NotImplementedException();
        }

        public List<Shop> GetAll()
        {
            return shopRepository.GetAll();
        }

        public Shop Update(int id, Shop shop)
        {
            try
            {
                Shop existShop = shopRepository.Get(g => g.Id == id);

                Shop existShopName = shopRepository.Get(g => g.Name.ToLower() == shop.Name.ToLower());

                if (existShop != null)
                {
                    existShop.Name = shop.Name;
                    existShop.MaxSize = shop.MaxSize;
                    return existShop;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {

                return null;
            }
        }
    }
}
