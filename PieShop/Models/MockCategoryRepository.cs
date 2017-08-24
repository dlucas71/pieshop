using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShop.Models 
{
    public class MockCategoryRepository: ICategoryRepository
    {
        public IEnumerable<Category> Categories
        {
            get
            {
                return new List<Category>
                {
                    new Category{Id=1, CategoryName="Fruit pies", Description="All-fruity pies"},
                    new Category{Id=2, CategoryName="Cheese cakes", Description="Cheesy all the way"},
                    new Category{Id=3, CategoryName="Seasonal pies", Description="Get in the mood for a seasonal pie"}
                };
            }
        }
    }
}
