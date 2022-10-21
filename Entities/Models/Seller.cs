using Entities.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
   public class Seller:IEntity
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public int Age { get; set; }

        public int Id { get; set; }

        public Shop Shop { get; set; }
    }
}
