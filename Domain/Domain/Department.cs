using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Department
    {
        public Guid Id { get; set; }
        public string DeptName { get; set; }
        public string DeptDescription { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
