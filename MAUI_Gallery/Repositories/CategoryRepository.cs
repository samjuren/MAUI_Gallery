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
                { 
                    new Component
                    {
                        Title = "StackLayout",
                        Description = "Organização sequencial dos elementos",
                        Page = typeof(StackLayoutPage)
                    },
                    new Component
                    {
                        Title = "Grid",
                        Description = "Organiza os elementos dentro de uma tabela",
                        Page = typeof(GridLayoutPage)
                    },
                    new Component
                    {
                        Title = "AbsoluteLayout",
                        Description = "Liberdade total para posicional e dimensionar os elementos na tela.",
                        Page = typeof(AbsoluteLayoutPage)
                    },
                    new Component
                    {
                        Title = "FlexLayout",
                        Description = "Organiza elementos de forma sequencial com muitas opções de personalização.",
                        Page = typeof(FlexLayoutPage)
                    }

                }
            });
            return categories;
        }
    }
}
