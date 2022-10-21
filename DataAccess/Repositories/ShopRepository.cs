using DataAccess.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Repositories
{
    public class ShopRepository : IRepository<Shop>
    {
        public bool Add(Shop Entity)
        {
            try
            {
                DbContext.shops.Add(Entity);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public Shop Get(Predicate<Shop> filter = null)
        {
            return filter == null ? DbContext.shops[0] :
               DbContext.shops.Find(filter);
        }

        public List<Shop> GetAll(Predicate<Shop> filter = null)
        {
            return filter == null ? DbContext.shops.ToList() :
                DbContext.shops.FindAll(filter).ToList();
        }

        public bool Remove(Shop Entity)
        {
            try
            {
                DbContext.shops.Remove(Entity);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool Update(Shop Entity)
        {
            try
            {
                Shop stu = Get(n => n.Name == Entity.Name);
                stu = Entity;

                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
