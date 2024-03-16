namespace shopping_system.Models
{
    public class CategoriesReopsitory
    {
        private static List<Category> _categories = new List<Category>()
        {
            new Category { CategoryId = 1, Name = "Beverage", Description = "bev" },
            new Category { CategoryId = 2, Name = "Bakery", Description = "bake" },
            new Category { CategoryId = 3, Name = "Meat", Description = "meat" }
        };
        public static void AddCategory(Category category)
        {
            var maxId = _categories.Max(x => x.CategoryId);
            category.CategoryId = maxId + 1;
            _categories.Add(category);
        }
        public static List<Category> GetCategories()
        {
            return _categories;
        }
        public static Category? GetCategoryById(int id)
        {
            
            var category =  _categories.FirstOrDefault(x => x.CategoryId == id);
            if(category != null)
            {
                return new Category
                {
                    CategoryId = category.CategoryId,
                    Name = category.Name,
                    Description = category.Description
                };

            }
            return null;
        }
        public static void UpdateCategory(int categoryId, Category category)
        {
            if (categoryId != null) return;
            var categoryToUpdate = _categories.FirstOrDefault(x => x.CategoryId == category.CategoryId);
            if(categoryToUpdate != null)
            {
                categoryToUpdate.Name = category.Name;
                categoryToUpdate.Description = category.Description;

            }

        }
        public static void DeleteCategory(int categoryId)
        {
            var category = _categories.FirstOrDefault(x => x.CategoryId == categoryId);
            if(category != null)
            {
                _categories.Remove(category);
            }
        }


    }
}
