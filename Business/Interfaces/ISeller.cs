using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Interfaces
{
    public interface ISeller
    {
        Seller Create(Seller seller, string shopName);

        Seller Update(Seller seller, string shopName);

        Seller Delete(int id);

        Seller Get(int id);

        List<Seller> Get(string shopName);

        List<Seller> GetAll(string name);

        List<Seller> GetAll();
    }
}
