using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Interfaces
{
    public interface IShop
    {
        Shop Create(Shop shop);

        Shop Delete(int id);

        Shop Update(int id, Shop shop);

        List<Shop> GetAll();

        Shop Get(int id);

        Shop Get(string name);
    }
}
