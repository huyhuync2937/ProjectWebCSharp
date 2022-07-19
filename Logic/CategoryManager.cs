using Project2.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Project2.Logic
{
    public class CategoryManager
    {
        internal static List<Category> GetAllCategory()
        {
            List < Category > categories = new List < Category >();
            using (var context = new DBContext())
            {
                categories = context.Categories.OrderBy(x => x.TypeId).ToList();
            }
            return categories;
        }
    }
}
