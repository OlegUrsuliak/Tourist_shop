using System;
using System.Collections.Generic;
using System.Text;

namespace TouristShop.Models.Goods
{
    class Equipment
    {
        public int id { get; set; }
        public string name { get; set; }
        public int number { get; set; }
        public int mass { get; set; }
        public int price { get; set; }
        public string description { get; set; }
        public int distributor_id { get; set; }

    }
}
