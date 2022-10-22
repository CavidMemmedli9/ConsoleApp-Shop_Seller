using Business.Interfaces;
using DataAccess.Repositories;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Services
{
    public class SellerService : ISeller
    {

        public ShopService shopService { get; set; }

        public SellerRepository sellerRepository { get; set; }

        public static int Count { get; set; }

        public SellerService()
        {
            shopService = new ShopService();
            sellerRepository = new SellerRepository();
        }

        public Seller Create(Seller seller, string shopName)
        {
            try
            {
                Shop shop = shopService.Get(shopName);
                if (shop != null)
                {
                    seller.Id = Count;
                    sellerRepository.Add(seller);
                    Count++;
                    return seller;
                }
               
                    return null;
               
            }
            catch (Exception)
            {

                return null;
            }
        }

        public Seller Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Seller Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Seller> Get(string shopName)
        {
            try
            {
                Shop shop = shopService.Get(shopName);
                if (shop != null)
                {
                    List<Seller> sellers = sellerRepository.GetAll(s => s.Shop.Name.ToLower() == shop.Name.ToLower());
                        return sellers;
                }
                return null;
            }
            catch (Exception)
            {

                return null;
            }
        }

        public List<Seller> GetAll(string name)
        {
            return sellerRepository.GetAll(s => s.Name.ToLower() == name.ToLower());
        }

        public List<Seller> GetAll()
        {
            return sellerRepository.GetAll();
        }

        public Seller Update(Seller seller, string shopName)
        {
            throw new NotImplementedException();
        }
    }
}
