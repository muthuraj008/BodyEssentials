using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Offer
    {
        public Guid Id { get; set; }
        public int ProductID { get; set; }
        public int DiscountID { get; set; }
    }
}
