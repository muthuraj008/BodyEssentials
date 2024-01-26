using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Catagory { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public int UnitPrice { get; set; }
        public int Ranking { get; set; }
        public string ProductDescription { get; set; }
        public int UnitInStock { get; set; }
        public int UnitInOrder { get; set; }
        //public byte[] ProductPic { get; set; }

        public Department Department { get; set; }

    }
}
