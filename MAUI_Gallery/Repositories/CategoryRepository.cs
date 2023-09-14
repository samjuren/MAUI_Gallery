using MAUI_Gallery.Models;
using MAUI_Gallery.Views.Layouts;

namespace MAUI_Gallery.Repositories
{
    public class CategoryRepository
    {
        public CategoryRepository(){}

        public List<Category> GetCategories()
        {
           List<Category> categories = new List<Category>();

            categories.Add(new Category
            {
                Name = "Layout",
                Components = new List<Component> 
                { new Component
                              {
                                Title = "StackLayout",
                                Description = "Organização sequencial dos elementos",
                                Page = typeof(StackLayoutPage)
                              }}
            });
            return categories;
        }
    }
}
