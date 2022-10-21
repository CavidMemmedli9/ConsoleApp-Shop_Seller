using Entities.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
    public class Shop : IEntity
    {
        public int Id { get; set; }


        public string Name { get; set; }

        public int MaxSize { get; set; }

        public List<Seller> Sellers { get; set; }
    }
}
