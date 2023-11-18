using Models;

namespace mUsic.Services.Views;

public class SubCategoryView
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int CategoryId { get; set; }

    
    public SubCategoryView(SubCategory subCategory)
    {
        Id = subCategory.Id;
        Name = subCategory.Name;
        CategoryId = subCategory.CategoryId;
    }
}