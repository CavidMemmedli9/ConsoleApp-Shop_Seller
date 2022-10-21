using DataAccess.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Repositories
{
    public class SellerRepository : IRepository<Seller>
    {
        public bool Add(Seller Entity)
        {
            try
            {
                DbContext.sellers.Add(Entity);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public Seller Get(Predicate<Seller> filter = null)
        {
            return filter == null ? DbContext.sellers.FirstOrDefault() :
                  DbContext.sellers.Find(filter);
        }

        public List<Seller> GetAll(Predicate<Seller> filter = null)
        {
            return filter== null ? DbContext.sellers.ToList() :
                 DbContext.sellers.FindAll(filter).ToList();
        }

        public bool Remove(Seller Entity)
        {
            try
            {
                DbContext.sellers.Remove(Entity);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool Update(Seller Entity)
        {
            try
            {
                Seller stu = Get(n => n.Name == Entity.Name);
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
