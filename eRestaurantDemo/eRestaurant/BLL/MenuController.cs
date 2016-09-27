using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eRestaurant.DAL;
using eRestaurant.Entities.DTOs;
using eRestaurant.Entities.POCOs;
using System.ComponentModel.DataAnnotations;

namespace eRestaurant.BLL
{
    public class MenuController
    {
        public List<CategoryWithItems> GetRestaurantMenu()
        {
            using (var context = new RestaurantContext())
            {
                var data = from aCategory in context.MenuCategories
                           orderby aCategory.Description
                           select new CategoryWithItems()
                           {
                               Description = aCategory.Description,
                               MenuItems = (from item in aCategory.MenuItems
                                            orderby item.Description
                                            select new MenuItem()
                                            {
                                                ItemDescription = item.Description,
                                                Price = item.CurrentPrice,
                                                Calories = item.Calories,
                                                Comment = item.Comment
                                            }).ToList()
                           };
                return data.ToList();
            }
        }
    }
}
