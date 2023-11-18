using Models;
namespace mUsic.Services.Views;


public class CollectionView
{
    public int Id { get; set; }
    public string Name { get; set; }

    public CollectionView(Collection collection)
    {
        Id = collection.Id;
        Name = collection.Name;
    }
}