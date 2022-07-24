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

        internal static bool IsExistCategory(string typeName)
        {
           using(var context = new DBContext())
            {
                Category category = context.Categories.FirstOrDefault(x => x.TypeName.Equals(typeName));
                if(category != null)
                    return true;
                else
                    return false;
            }
        }

        internal static void SetNewCategory(Category category)
        {
            using (var context = new DBContext())
            {
                context.Categories.Add(category);
                context.SaveChanges();
            }
        }
    }
}
