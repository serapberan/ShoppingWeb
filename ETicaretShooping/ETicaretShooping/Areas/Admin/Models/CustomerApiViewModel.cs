using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETicaretShooping.Areas.Admin.Models
{
    public class CustomerApiViewModel
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string UserName { get; set; }
        public string Mail { get; set; }
    }
}
