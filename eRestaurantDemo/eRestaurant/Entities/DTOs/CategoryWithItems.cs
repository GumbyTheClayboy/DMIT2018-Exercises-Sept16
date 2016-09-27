using eRestaurant.Entities.POCOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRestaurant.Entities.DTOs
{
    public class CategoryWithItems
    {
        public string Description { get; set; }
        public IEnumerable<MenuItem> MenuItems { get; set; }
    }
}
