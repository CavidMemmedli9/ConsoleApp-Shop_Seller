using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
   public static class DbContext
    {
        public static List<Seller> sellers;

        public static List<Shop> shops;

        static DbContext()
        {
            sellers = new List<Seller>();
            shops = new List<Shop>();
        }
    }
}
