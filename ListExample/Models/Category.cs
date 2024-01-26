namespace ListExample.Models
{


    public class Categories
    {
        public Category[]? CategoriesList { get; set; }
    }

    public class Category
    {
        public string? Name { get; set; }
        public Category[] Categories { get; set; } = new Category[0];
    }


}
